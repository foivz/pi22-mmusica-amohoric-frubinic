using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_for_you
{
    public partial class PCForYouForm : Form
    {
        public string KorimePrijavljenog = "";
        public int UlogaPrijavljenog = 0;
        public PCForYouForm()
        {
            InitializeComponent();
           
        }
        

        private void PCForYouForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijaForm registracijaForm = new RegistracijaForm();
            registracijaForm.ShowDialog();
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            string greska = "";
            if (txtKorime.Text.Equals("")) greska += "Korisničko ime nije uneseno!";
            if (txtLozinka.Text.Equals("")) greska += "Lozinka nije unesena!";
            
            if (greska.Equals(""))
            {
                using(var context = new PI2233_DBEntities())
                {
                    List<korisnik> korisnici = context.korisnik.ToList();
                    korisnik pronadjenKorisnik = null;
                    foreach(korisnik korisnik in context.korisnik.ToList())
                    {
                        
                        if (korisnik.UserName.Equals(txtKorime.Text))
                        {
                            
                            pronadjenKorisnik = korisnik;
                            if (pronadjenKorisnik.Password.Equals(txtLozinka.Text))
                            {
                                
                                KorimePrijavljenog = pronadjenKorisnik.UserName;
                                UlogaPrijavljenog = pronadjenKorisnik.Uloga;
                            }
                            break;
                        }
                    }
                    if(pronadjenKorisnik == null) {
                        MessageBox.Show("To korisničko ime ne postoji!");
                    }
                }
            }
            else
            {
                MessageBox.Show(greska);
            }
            Sesija.DodajKorisnika(KorimePrijavljenog);
            MessageBox.Show("Prijavljeni korisnik: " + Sesija.Korime + " - " + UlogaPrijavljenog);
            if(UlogaPrijavljenog != 0)
            {
                PocetnaStranicaForm form = new PocetnaStranicaForm(UlogaPrijavljenog, KorimePrijavljenog);
                this.Hide();
                form.ShowDialog();
                this.Show();
                UlogaPrijavljenog = 0;
                KorimePrijavljenog = "";
            }
        }
        
    }
}
