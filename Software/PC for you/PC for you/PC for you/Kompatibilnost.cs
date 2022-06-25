using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_for_you
{
    public class Kompatibilnost
    {
        private List<maticna> ListaMaticna { get; set; }
        private List<komponenta> ListaKomponenta { get; set; }
        private bool Kompatibilni { get; set; }
        private string Poruka { get; set; }
        private komponenta graficka = null;
        private komponenta kuciste = null;
        private komponenta napajanje = null;
        private komponenta ram = null;
        private komponenta procesor = null;
        private komponenta pohrana = null;
        private maticna maticna = null;

        public Kompatibilnost(List<maticna> listaMaticna, List<komponenta> listaKomponenta)
        {
            ListaMaticna = listaMaticna;
            ListaKomponenta = listaKomponenta;
            Kompatibilni = true;
            Poruka = "";
            PostaviKomponente();
        }
        public bool ProvjeriKompatibilnost()
        {

            Poruka = "";
            ProvjeriPotrosnju();
            ProvjeriVelicinuGraficke();
            ProvjeriIntefaceMaticneIGraficke();
            ProvjeriPodrzavanuMaticnu();
            ProvjeriTipMemorije();
            ProvjeriSocket();
            if (Kompatibilni) Poruka = "Vaše komponente su kompatibilne!";
            System.Windows.Forms.MessageBox.Show(Poruka);


            return Kompatibilni;
        }

        private void ProvjeriSocket()
        {
            
            if(maticna.Socket != procesor.Socket)
            {
                Kompatibilni = false;
                Poruka += "Socket matične i procesora nije isti! " + maticna.Socket + " - " + procesor.Socket + ". ";
                
            }
        }

        private void ProvjeriTipMemorije()
        {
            
            
                if(ram.Tip_memorije != maticna.Tip_memorije)
                {
                    Poruka += "Tip RAM memorije ne odgovara tipu memorije za odabranu matičnu ploču! " + ram.Tip_memorije + " - " + maticna.Tip_memorije + ". ";
                }
            

        }

        private void ProvjeriPodrzavanuMaticnu()
        {
            
            string[] podrzavaneMaticne = kuciste.Podrzavana_maticna.Split(',');
            bool podrzava = false;
            foreach(string str in podrzavaneMaticne)
            {
                if (str == maticna.Velicina)
                {
                    podrzava = true;
                    break;
                }
            }
            if (!podrzava)
            {
                Poruka += "Odabrano kućište ne podržava veličinu odabrane matične! ";
                Kompatibilni = false;
            }
        }

        private void ProvjeriIntefaceMaticneIGraficke()
        {
            
            if (maticna.InterfacePCIe8==1 &&  maticna.InterfacePCIe16==0 && graficka.Interface == "PCIe x16")
            {
                this.Kompatibilni = false;
                Poruka += "Interface matične i grafičke nije kompatibilan! ";
            }
        }

        private void ProvjeriVelicinuGraficke()
        {
            
            if(graficka.Duzina_graficke > kuciste.Maksimalna_duzina_graficke)
            {
                this.Kompatibilni = false;
                Poruka += "Grafička je prevelika za odabrano kućište!" + graficka.Duzina_graficke + " - " + kuciste.Maksimalna_duzina_graficke + ". ";
            }
        }

        private void ProvjeriPotrosnju()
        {
            double potrosnja = 0;
            foreach(komponenta komponenta in ListaKomponenta)
            {
                potrosnja += komponenta.Potrosnja;
            }

            potrosnja += ListaMaticna.First().Potrosnja;

            if(napajanje.Kapacitet_napajanja < potrosnja)
            {
                this.Kompatibilni = false;
                Poruka += "Napajanje je preslabo! " + potrosnja + " - " + napajanje.Kapacitet_napajanja + ". ";
            }
        }
        private void PostaviKomponente()
        {
            
            foreach (komponenta komponenta in ListaKomponenta)
            {
                if (komponenta.Tip == "Graficka")
                {
                    graficka = komponenta;
                }
                if (komponenta.Tip == "Kucista")
                {
                    kuciste = komponenta;
                }
                if (komponenta.Tip == "Napajanje")
                {
                    napajanje = komponenta;
                }
                if (komponenta.Tip == "RAM")
                {
                    ram = komponenta;
                }
                if (komponenta.Tip == "Procesor")
                {
                    procesor = komponenta;
                }
                if (komponenta.Tip == "Pohrana")
                {
                    pohrana = komponenta;
                }
            }
            maticna = ListaMaticna.First();
        }

    }
}
