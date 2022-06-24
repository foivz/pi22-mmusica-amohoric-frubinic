using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_for_you
{
    public static class Sesija
    {
        public static string Korime { get; set; }
        public static void DodajKorisnika(string korime)
        {
            Korime = korime;
        }
    }
}
