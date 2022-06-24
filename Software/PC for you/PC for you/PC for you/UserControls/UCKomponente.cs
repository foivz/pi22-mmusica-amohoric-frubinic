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
            DohvatiKomponente dohvatiKomponente = new DohvatiKomponente(tip, dgvKomponente);
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
                    maticna mat = null;
                    foreach (maticna item in context.maticna)
                    {
                        if (item.IdMaticne == komId)
                        {
                            mat = item;
                            break;
                        }
                    }

                    if (mat != null)
                    {
                        listaMaticna.Add(mat);
                        MessageBox.Show("Uspješno ste dodali komponentu u košaricu");
                    }

                }
            }
            else
            {
                using (var context = new PI2233_DBEntities())
                {
                    komponenta komp = null;
                    foreach (komponenta item in context.komponenta)
                    {
                        if (item.IdKomponenta == komId)
                        {
                            komp = item;
                            break;
                        }
                    }
                    if (komp != null)
                    {
                        listaKomponenata.Add(komp);
                        MessageBox.Show("Uspješno ste dodali komponentu u košaricu");
                    }


                }
            }

        }

        private void btnSloziRacunalo_Click(object sender, EventArgs e)
        {
            SloziRacunaloForm sloziRacunaloForm = new SloziRacunaloForm();
            sloziRacunaloForm.Show();
        }

        private void btnOdaberiKomponentu_Click(object sender, EventArgs e)
        {
            listBoxKomponenta.Items.Clear();
            string prenesenaKomponenta = dgvKomponente.CurrentRow.Cells[0].Value.ToString() + "-" + dgvKomponente.CurrentRow.Cells[1].Value.ToString() + ":" +  cboxKomponente.SelectedItem.ToString();
            listBoxKomponenta.Items.Add(prenesenaKomponenta);
            MessageBox.Show("Komponentu u kućici iznad možete sada drag and droppat na kostur računala!");
        }

        private void listBoxKomponenta_MouseDown(object sender, MouseEventArgs e)
        {
            listBoxKomponenta.DoDragDrop(this.listBoxKomponenta.SelectedItem.ToString(), DragDropEffects.Copy);

        }
    }
}
