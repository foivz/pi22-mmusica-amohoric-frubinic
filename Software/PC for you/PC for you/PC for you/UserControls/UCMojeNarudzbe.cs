using DllLibrary;
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
    public partial class UCMojeNarudzbe : UserControl
    {
        private string korime;
        public UCMojeNarudzbe()
        {
            InitializeComponent();
        }

        private void UCMojeNarudzbe_Load(object sender, EventArgs e)
        {
            korime = Sesija.Korime;
            DohvatiNarudzbe();
        }

        private void DohvatiNarudzbe()
        {
            using (var context = new PI2233_DBEntities())
            {
                var query = from n in context.narudzba
                            where n.korisnik.UserName == korime
                            select n;
                dgvNarudzbe.DataSource = query.ToList();
                dgvNarudzbe.Columns["korisnik"].Visible = false;
                dgvNarudzbe.Columns["narucuje"].Visible = false;
            }
            DohvatiDetaljeNarudzbe();
        }

        private void DohvatiDetaljeNarudzbe()
        {
            dgvDetaljiNarudzbe.DataSource = null;
            dgvDetaljiNarudzbe.Rows.Clear();
            int id = (int)dgvNarudzbe.CurrentRow.Cells[0].Value;
            using(var context = new PI2233_DBEntities())
            {
                var query = (from n in context.narucuje
                             where n.IdNarudzbe == id && n.komponenta != null
                             select new
                             {
                                 Naziv = n.komponenta.Naziv,
                                 Količina = n.Kolicina,
                                 Tip = n.komponenta.Tip,
                                 Proizvođač = n.komponenta.Proizvodac,
                                 Jedinična_cijena = n.komponenta.Cijena
                             }).ToList();
                var query2 = (from n in context.narucuje
                             where n.IdNarudzbe == id && n.maticna != null
                             select new
                             {
                                 Naziv = n.maticna.Naziv,
                                 Količina = n.Kolicina,
                                 Tip = "Maticna",
                                 Proizvođač = n.maticna.Proizvodac,
                                 Jedinična_cijena = n.maticna.Cijena
                             }).ToList();
                foreach (var k in query)
                {
                    dgvDetaljiNarudzbe.Rows.Add(k.Naziv, k.Količina, k.Tip, k.Proizvođač, k.Jedinična_cijena);
                }
                foreach (var m in query2)
                {
                    dgvDetaljiNarudzbe.Rows.Add(m.Naziv, m.Količina, m.Tip, m.Proizvođač, m.Jedinična_cijena);
                }
            }

        }

        private void dgvNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            DohvatiDetaljeNarudzbe();
        }

        private void UCMojeNarudzbe_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "../../Resources/PC4YOU.chm", HelpNavigator.Topic, "3Mojenarudzbe.htm");
        }
    }
}
