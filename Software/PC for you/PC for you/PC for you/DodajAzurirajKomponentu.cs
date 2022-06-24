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
    public partial class DodajAzurirajKomponentu : Form
    {
        private string Tip;
        private int ID = 0;
        public DodajAzurirajKomponentu(string tip, int id)
        {
            Tip = tip;
            ID = id;
            InitializeComponent();
        }
        public DodajAzurirajKomponentu(string tip)
        {
            Tip = tip;
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            komponenta komponenta = new komponenta();
            string greska = "";
            if (txtNazivKomponente.Text == "" || txtProizvodac.Text == "" || txtCijena.Text == "")
                greska = "Molimo popunite sva polja!";
            if (!int.TryParse(txtCijena.Text, out int cijena))
            {
                greska += "Cijena neispravnog formata!";
            }
            if (greska == "")
            {
                komponenta.Tip = Tip;
                komponenta.Proizvodac = txtProizvodac.Text;
                komponenta.Cijena = int.Parse(txtCijena.Text);
                switch (Tip)
                {
                    case "Procesor":
                        {
                            if(txtBrzina.Text =="" || txtSocekt.Text =="") greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {
                                    komponenta.Brzina = txtBrzina.Text;
                                    komponenta.Socket = txtSocekt.Text;
                            }
                                break;
                        }
                    case "Graficka":
                        {
                            if (txtInterface.Text == "" || txtDuzinaGraficke.Text == "" || txtVRAM.Text =="") 
                                greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {
                                if(!double.TryParse(txtDuzinaGraficke.Text, out double duzina))
                                {
                                    greska += "Neispravan format dužine grafičke!";
                                    break;
                                }
                                else
                                {
                                    komponenta.Interface = txtInterface.Text;
                                    komponenta.Duzina_graficke = double.Parse(txtDuzinaGraficke.Text);
                                    komponenta.Vram = txtVRAM.Text;
                                }
                                
                            }
                            break;
                        }
                    case "Napajanje":
                        {
                            if (txtKapacitetNapajanja.Text =="") greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {
                                if(!int.TryParse(txtKapacitetNapajanja.Text, out int kapacitet))
                                {
                                    greska += "Neispravan format kapaciteta napajanja!";
                                    break;
                                }
                                else
                                {
                                    komponenta.Kapacitet_napajanja = int.Parse(txtKapacitetNapajanja.Text);
                                }
                                
                            }
                            break;
                        }
                    case "Maticna":
                        {
                            if (txtSocekt.Text == "" || txtVelicinaMaticne.Text == "" || txtTipMemorije.Text == ""||
                                numBrojModula.Value ==0) 
                                greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {

                            }
                            break;
                        }
                    case "RAM":
                        {
                            if (txtTipMemorije.Text == "" || txtVelicinaMemorije.Text == "" || txtBrzina.Text =="") 
                                greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {
                                komponenta.Tip_memorije = txtTipMemorije.Text;
                                komponenta.Brzina = txtBrzina.Text;
                                komponenta.Velicina_memorije = txtVelicinaMemorije.Text;
                            }
                            break;
                        }
                    case "Pohrana":
                        {
                            if (txtKapacitetPohrane.Text == "" || txtInterface.Text == "") greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {
                                komponenta.KapacitetPohrane = txtKapacitetPohrane.Text;
                                komponenta.Interface = txtInterface.Text;
                            }
                            break;
                        }
                    case "Kucista":
                        {
                            if (txtMaxGraficka.Text == "" || txtPodrzavanaMaticna.Text == "") greska = "Molimo popunite sva polja!";
                            if (greska == "")
                            {
                                if (!double.TryParse(txtMaxGraficka.Text, out double duzina))
                                {
                                    greska += "Neispravan format dužine grafičke!";
                                    break;
                                }
                                else
                                {
                                    komponenta.Maksimalna_duzina_graficke = double.Parse(txtMaxGraficka.Text);
                                    komponenta.Podrzavana_maticna = txtPodrzavanaMaticna.Text;
                                }
                            }
                            break;
                        }
                }
                using (var context = new PI2233_DBEntities())
                {
                    context.komponenta.Attach(komponenta);
                    context.komponenta.Add(komponenta);
                    context.SaveChanges();
                }
            }
            else
                    {
                        MessageBox.Show(greska);
                    }
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PrikaziSkarij()
        {
            txtVrstaKomponente.Text = Tip;
            txtIDKomponente.Text = ID.ToString();
            switch (Tip)
            {
                case "Procesor":
                    {
                        txtBrzina.Enabled = true;
                        txtSocekt.Enabled = true;
                        break;
                    }
                case "Graficka":
                    {
                        txtInterface.Enabled = true;
                        txtDuzinaGraficke.Enabled = true;
                        txtVRAM.Enabled = true;
                        break;
                    }
                case "Napajanje":
                    {
                        txtPotrosnja.Text = "0";
                        txtPotrosnja.Enabled = false;
                        txtKapacitetNapajanja.Enabled = true;
                        break;
                    }
                case "Maticna":
                    {
                        txtSocekt.Enabled = true;
                        txtVelicinaMaticne.Enabled = true;
                        txtTipMemorije.Enabled = true;
                        numBrojModula.Enabled = true;
                        chkPCIe16.Enabled = true;
                        chkPCIe8.Enabled = true;
                        break;
                    }
                case "RAM":
                    {
                        txtTipMemorije.Enabled = true;
                        txtBrzina.Enabled = true;
                        txtVelicinaMemorije.Enabled = true;
                        break;
                    }
                case "Pohrana":
                    {
                        txtInterface.Enabled = true;
                        txtKapacitetPohrane.Enabled = true;
                        break;
                    }
                case "Kucista":
                    {
                        txtMaxGraficka.Enabled = true;
                        txtPodrzavanaMaticna.Enabled = true;
                        break;
                    }
            }

        }

        private void DodajAzurirajKomponentu_Load(object sender, EventArgs e)
        {
            PrikaziSkarij();
        }
    }
}
