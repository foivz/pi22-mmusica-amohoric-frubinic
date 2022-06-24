using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_for_you.UserControls
{
    public partial class UCKosarica : UserControl
    {
        private List<komponenta> listaKomponenata;
        private List<maticna> listaMaticna;
        private static List<KomponentaZaKosaricu> listaKomponenataZaKosaricu = new List<KomponentaZaKosaricu>();
        public UCKosarica(List<komponenta> listaK, List<maticna> listaM)
        {
            listaMaticna = listaM;
            listaKomponenata = listaK;
            InitializeComponent();
        }

        private void UCKosarica_Load(object sender, EventArgs e)
        {
            NapuniListuKomponenataKosarice();
            RefreshDGV();
        }

        private void NapuniListuKomponenataKosarice()
        {
            listaKomponenataZaKosaricu.Clear();
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

        private void RefreshDGV()
        {
            dgvKosarica.DataSource = null;
            dgvKosarica.DataSource = listaKomponenataZaKosaricu;
        }

    }
}
