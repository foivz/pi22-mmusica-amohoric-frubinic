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
    public partial class RegistracijaForm : Form
    {
        public RegistracijaForm()
        {
            InitializeComponent();
        }

        private void RegistracijaForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            if (textBoxPonovljenaLozinka.Text == textBoxLozinka.Text) 
            {
                bool korimePostoji;
                string korime = textBoxKorime.Text;

                using (var context = new PI2233_DBEntities())
                {
                    var found = (from k in context.korisnik
                                where k.UserName == korime
                                select k).ToList();
                    korimePostoji = found.Any();           
                }
                if (!korimePostoji) 
                {
                    using (var context = new PI2233_DBEntities())
                    {
                        string lozinka = textBoxLozinka.Text;
                        string adresa = textBoxAdresa.Text;
                        string email = textBoxEmail.Text;
                        string imePrezime = textBoxImePrezime.Text;
                        int uloga = 2; //Default registracije nam postavlja ulogu na korisnika

                        korisnik korisnik = new korisnik
                        {
                            Adresa = adresa,
                            E_mail = email,
                            Ime_prezime = imePrezime,
                            Password = lozinka,
                            UserName = imePrezime,
                            Uloga = uloga
                        };
                        context.korisnik.Add(korisnik);
                        context.SaveChanges();
                        MessageBox.Show("Uspješno ste se registrirali!");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ovakvo korisničko ime već postoji! Molimo Vas da ponovno unesete podatke");
                }
            }
            else
            {
                MessageBox.Show("Lozinke vam nisu iste! Molimo Vas da unesete opet");
            }
            
        }
    }
}
