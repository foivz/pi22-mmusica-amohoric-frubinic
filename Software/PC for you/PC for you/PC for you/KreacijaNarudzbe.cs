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

    }
}
