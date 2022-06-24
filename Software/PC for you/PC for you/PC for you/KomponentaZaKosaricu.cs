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
    }
}
