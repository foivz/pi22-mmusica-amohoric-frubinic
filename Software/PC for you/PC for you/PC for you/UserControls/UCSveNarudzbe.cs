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
    public partial class UCSveNarudzbe : UserControl
    {
        public UCSveNarudzbe()
        {
            InitializeComponent();
        }

        private void UCSveNarudzbe_Load(object sender, EventArgs e)
        {
            DohvatiSveNarudzbe();
        }

        private void DohvatiSveNarudzbe()
        {
            using (var context = new PI2233_DBEntities())
            {
                var query = from n in context.narudzba
                            select new{
                                ID_narudze = n.IdNarudzba,
                                Korisnik = n.korisnik.UserName,
                                Datum = n.Datum,
                                Cijena = n.Ukupna_cijena
                };
                dgvSveNarudzbe.DataSource = query.ToList();
            }
            DohvatiDetaljeNarudzbe();
        }

        private void DohvatiDetaljeNarudzbe()
        {
            dgvDetaljiSveNarudzbe.DataSource = null;
            dgvDetaljiSveNarudzbe.Rows.Clear();
            int id = (int)dgvSveNarudzbe.CurrentRow.Cells[0].Value;
            using (var context = new PI2233_DBEntities())
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
                    dgvDetaljiSveNarudzbe.Rows.Add(k.Naziv, k.Količina, k.Tip, k.Proizvođač, k.Jedinična_cijena);
                }
                foreach (var m in query2)
                {
                    dgvDetaljiSveNarudzbe.Rows.Add(m.Naziv, m.Količina, m.Tip, m.Proizvođač, m.Jedinična_cijena);
                }
            }
        }

        private void dgvSveNarudzbe_SelectionChanged(object sender, EventArgs e)
        {
            DohvatiDetaljeNarudzbe();
        }

        private void btnObrisiNarudzbu_Click(object sender, EventArgs e)
        {
            int id = (int)dgvSveNarudzbe.CurrentRow.Cells[0].Value;
            using (var context = new PI2233_DBEntities())
            {
                var query = (from n in context.narucuje
                             where n.IdNarudzbe == id
                             select n).ToList();
                foreach(var n in query)
                {
                    context.narucuje.Attach(n);
                    context.narucuje.Remove(n);
                    context.SaveChanges();
                }
                var query2 = (from n in context.narudzba
                              where n.IdNarudzba == id
                              select n).ToList().First();
                context.narudzba.Attach(query2);
                context.narudzba.Remove(query2);
                context.SaveChanges();
            }
            DohvatiSveNarudzbe();
        }
    }
}
