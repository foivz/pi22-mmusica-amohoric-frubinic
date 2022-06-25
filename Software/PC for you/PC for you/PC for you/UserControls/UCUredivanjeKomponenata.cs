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
    public partial class UCUredivanjeKomponenata : UserControl
    {
        public UCUredivanjeKomponenata()
        {
            InitializeComponent();
        }
        private void PopuniComboBox()
        {
            List<string> ListaKomponenata = new List<string>
        {
            "Procesor",
            "Graficka",
            "Napajanje",
            "Maticna",
            "RAM",
            "Pohrana",
            "Kucista"
            };
            cmbVrsteKomponenata.DataSource = ListaKomponenata;
        }

        private void UCUredivanjeKomponenata_Load(object sender, EventArgs e)
        {
            PopuniComboBox();
            DohvatiPodatke();
        }

        private void cmbVrsteKomponenata_SelectedIndexChanged(object sender, EventArgs e)
        {
            DohvatiPodatke();
        }
        private void DohvatiPodatke()
        {
            string tip = cmbVrsteKomponenata.SelectedItem.ToString();
            DohvatiKomponente dohvatiKomponente = new DohvatiKomponente(tip, dgvUredivanjeKomponenata);
            dohvatiKomponente.DohvatiZeljenuKomponentu();
        }

        private void btnDodajKomponentu_Click(object sender, EventArgs e)
        {
            DodajAzurirajKomponentu form = new DodajAzurirajKomponentu(cmbVrsteKomponenata.SelectedItem.ToString());
            form.ShowDialog();
            DohvatiPodatke();
        }

        private void btnAzurirajOdabranu_Click(object sender, EventArgs e)
        {
            string tip = cmbVrsteKomponenata.SelectedItem.ToString();
            int id = Convert.ToInt32(dgvUredivanjeKomponenata.CurrentRow.Cells[0].Value);
            DodajAzurirajKomponentu form = new DodajAzurirajKomponentu(tip, id);
            form.ShowDialog();
            DohvatiPodatke();
        }

        private void btnObrisiKomponentu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUredivanjeKomponenata.CurrentRow.Cells[0].Value);
            IzbrisiKomponentu(id);
            DohvatiPodatke();
        }

        private void IzbrisiKomponentu(int id)
        {
            using (var context = new PI2233_DBEntities())
            {
                
                if(cmbVrsteKomponenata.SelectedItem.ToString() != "Maticna")
                {
                   var query = (from k in context.komponenta
                             where k.IdKomponenta == id
                             select k).ToList().First();

                    context.komponenta.Attach(query);

                    var query1 = (from n in context.narucuje
                                  where n.komponenta.IdKomponenta == id
                                  select n).ToList();
                    foreach(narucuje n in query1)
                    {
                        context.narucuje.Attach(n);
                        context.narucuje.Remove(n);
                    }

                    context.komponenta.Remove(query);
                    context.SaveChanges();
                }
                else
                {
                   var query = (from m in context.maticna
                             where m.IdMaticne == id
                             select m).ToList().First();

                    context.maticna.Attach(query);

                    var query1 = (from n in context.narucuje
                                  where n.maticna.IdMaticne == id
                                  select n).ToList();

                    foreach (narucuje n in query1)
                    {
                        context.narucuje.Attach(n);
                        context.narucuje.Remove(n);
                    }

                    context.maticna.Remove(query);
                    context.SaveChanges();
                }
            }
        }
    }
}
