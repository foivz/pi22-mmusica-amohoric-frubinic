using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
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
