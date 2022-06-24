using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_for_you
{
    public class KreacijaNarudzbe
    {
        public static List<KreacijaNarudzbe> ListaKomponenataZaNarudzbu = new List<KreacijaNarudzbe>();
        public int ID { get; set; }
        public string Tip { get; set; }
        
       
        public KreacijaNarudzbe()
        {

        }
        public KreacijaNarudzbe( int id, string tip)
        {
            ID = id;
            Tip = tip;
        }
        public void DodajKomponentuZaNarudzbu(KreacijaNarudzbe kreacijaNarudzbe)
        {
            ListaKomponenataZaNarudzbu.Add(kreacijaNarudzbe);
        }
        public void NaruciKomponente()
        {
            narudzba novaNarudzba;
            List<komponenta> listaNarucenaKomponenta = new List<komponenta>();
            List<maticna> ListaNarucenaMaticna = new List<maticna>();
            korisnik korisnikNarucitelj = new korisnik();
            
            using (var context = new PI2233_DBEntities())
            {
                foreach (korisnik korisnik in context.korisnik)
                {
                    if (korisnik.UserName == Sesija.Korime) 
                    {
                        korisnikNarucitelj = korisnik;
                        break;
                    }
                }
                foreach (KreacijaNarudzbe narucenaKomponenta in ListaKomponenataZaNarudzbu)
                {
                    if (narucenaKomponenta.Tip == "Maticna")
                    {
                        foreach (maticna maticna in context.maticna)
                        {
                            if (maticna.IdMaticne == narucenaKomponenta.ID)
                            {
                                ListaNarucenaMaticna.Add(maticna);
                                break;
                            }
                        }
                    }
                    else
                    {
                        foreach (komponenta komponenta in context.komponenta)
                        {
                            if (komponenta.IdKomponenta == narucenaKomponenta.ID)
                            {
                                listaNarucenaKomponenta.Add(komponenta);
                                break;
                            }
                        }
                    }
                }

            }
            double ukupnaCijena=0;
            if (listaNarucenaKomponenta.Any()) ukupnaCijena += listaNarucenaKomponenta.Sum(x => x.Cijena);
            if(ListaNarucenaMaticna.Any()) ukupnaCijena += ListaNarucenaMaticna.Sum(x => x.Cijena);

            using (var narudzbaContext = new PI2233_DBEntities())
            {
                narudzbaContext.korisnik.Attach(korisnikNarucitelj);
                novaNarudzba = new narudzba
                {
                    Datum = DateTime.Now,
                    IdKorisnika = korisnikNarucitelj.IdKorisnik,
                    korisnik = korisnikNarucitelj,
                    Ukupna_cijena = ukupnaCijena,
                    
                };
                narudzbaContext.narudzba.Add(novaNarudzba);
                narudzbaContext.SaveChanges();
            }
        }

    }
}
