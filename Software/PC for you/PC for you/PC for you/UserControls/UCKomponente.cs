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
        private List<komponenta> listaKomponenata;
        private List<maticna> listaMaticna;
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
        public UCKomponente(List<komponenta> listaK, List<maticna> listaM)
        {
            listaKomponenata = listaK;
            listaMaticna = listaM;
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

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            var id = dgvKomponente.CurrentRow.Cells[0].Value;
            int komId = int.Parse(id.ToString());

            if (cboxKomponente.SelectedItem.ToString() == "Maticna")
            {
                using (var context = new PI2233_DBEntities())
                {
                    var mat = from m in context.maticna
                               where m.IdMaticne == komId
                               select m;

                    listaMaticna.Add(mat as maticna);

                }
            }
            else 
            {
                using (var context = new PI2233_DBEntities())
                {
                    var komp = from k in context.komponenta
                               where k.IdKomponenta == komId
                               select k;

                    listaKomponenata.Add(komp as komponenta);

                }
            }
            
        }
    }
}
