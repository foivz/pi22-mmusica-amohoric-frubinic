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
            var listaMaticnaBezDuplikata = ListaNarucenaMaticna.GroupBy(x => x.IdMaticne).Select(x => x.First()).ToList();
            var listaKomponenataBezDuplikata = listaNarucenaKomponenta.GroupBy(x => x.IdKomponenta).Select(x => x.First()).ToList();

            foreach (maticna narucenaMaticna in listaMaticnaBezDuplikata)
            {
                using (var narucujuContext = new PI2233_DBEntities())
                {
                    narucujuContext.narudzba.Attach(novaNarudzba);
                    narucujuContext.maticna.Attach(narucenaMaticna);
                    int kolicina = ListaNarucenaMaticna.FindAll(x=>x.IdMaticne ==narucenaMaticna.IdMaticne).Count();
                    
                    narucuje noviNarucuje = new narucuje
                    {
                        IdMaticne=narucenaMaticna.IdMaticne,
                        IdNarudzbe=novaNarudzba.IdNarudzba,
                        maticna=narucenaMaticna,
                        Kolicina = kolicina,
                        narudzba=novaNarudzba

                    };
                    narucujuContext.narucuje.Add(noviNarucuje);
                    narucujuContext.SaveChanges();
                    
                }
            }
            foreach (komponenta narucenaKomponenta in listaKomponenataBezDuplikata)
            {
                using (var komponentaContext = new PI2233_DBEntities())
                {
                    komponentaContext.narudzba.Attach(novaNarudzba);
                    komponentaContext.komponenta.Attach(narucenaKomponenta);
                    int kolicina = listaNarucenaKomponenta.FindAll(x=> x.IdKomponenta == narucenaKomponenta.IdKomponenta).Count();
                    
                    narucuje noviNarucuje = new narucuje
                    {
                        IdKomponente = narucenaKomponenta.IdKomponenta,
                        IdNarudzbe = novaNarudzba.IdNarudzba,
                        Kolicina = kolicina,
                        komponenta = narucenaKomponenta,
                        narudzba = novaNarudzba
                    };
                    komponentaContext.narucuje.Add(noviNarucuje);
                    komponentaContext.SaveChanges();
                }
               
            }
            ListaKomponenataZaNarudzbu.Clear();
            RacunPDF racunPDF = new RacunPDF(novaNarudzba.IdNarudzba, Sesija.Korime);

        }

    }
}
