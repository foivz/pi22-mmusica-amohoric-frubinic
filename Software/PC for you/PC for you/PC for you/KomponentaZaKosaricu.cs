using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_for_you
{
    public class KomponentaZaKosaricu
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Proizvodac { get; set; }
        public double Potrosnja { get; set; }
        public double Cijena { get; set; }
        public string Tip { get; set; }

        public KomponentaZaKosaricu()
        {

        }
        public static void NapuniListuKomponenataKosarice(List<komponenta> listaKomponenata,
            List<maticna> listaMaticna, List<KomponentaZaKosaricu> listaKomponenataZaKosaricu)
        {
            listaKomponenataZaKosaricu.Clear();
            if (listaKomponenata.Any())
            {
                foreach (komponenta item in listaKomponenata)
                {
                    KomponentaZaKosaricu novaKomponenta = new KomponentaZaKosaricu
                    {
                        ID = item.IdKomponenta,
                        Naziv = item.Naziv,
                        Proizvodac = item.Proizvodac,
                        Tip = item.Tip,
                        Potrosnja = item.Potrosnja,
                        Cijena = item.Cijena

                    };
                    listaKomponenataZaKosaricu.Add(novaKomponenta);
                }
            }
            
            if(listaMaticna.Any())
            {
                foreach (maticna item in listaMaticna)
                {
                    KomponentaZaKosaricu novaKomponenta = new KomponentaZaKosaricu
                    {
                        ID = item.IdMaticne,
                        Naziv = item.Naziv,
                        Proizvodac = item.Proizvodac,
                        Tip = "Maticna",
                        Potrosnja = item.Potrosnja,
                        Cijena = item.Cijena

                    };
                    listaKomponenataZaKosaricu.Add(novaKomponenta);
                }
            }
            
        }
    }
}
