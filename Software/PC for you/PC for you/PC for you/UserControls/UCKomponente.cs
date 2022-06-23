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
    public partial class UCKomponente : UserControl
    {
        public static List<string> ListaKomponenata = new List<string>
        { 
            "Procesor",
            "Graficka",
            "Napajanje",
            "Maticna",
            "RAM",
            "Pohrana",
            "Kucista"

        };
        public UCKomponente()
        {
            InitializeComponent();
        }

        private void UCKomponente_Load(object sender, EventArgs e)
        {
            RefreshCBox();
            RefreshKomponente();
        }

        private void RefreshKomponente()
        {
            string tip = cboxKomponente.SelectedItem.ToString();
            DohvatiKomponente dohvatiKomponente = new DohvatiKomponente(tip,dgvKomponente);
            dohvatiKomponente.DohvatiZeljenuKomponentu();
        }

        private void RefreshCBox()
        {

            cboxKomponente.DataSource = ListaKomponenata;
            cboxKomponente.SelectedIndex = 0;
        }

        private void cboxKomponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshKomponente();
        }
    }
}
