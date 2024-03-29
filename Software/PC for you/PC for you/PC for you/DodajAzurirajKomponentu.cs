﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            using (var context = new PI2233_DBEntities())
            {
                komponenta komponenta = null; 
                maticna maticna = null;
                if(ID == 0)
                {
                    maticna = new maticna();
                    komponenta = new komponenta();
                }
                else
                {
                    if(Tip == "Maticna")
                    {
                        maticna = (from m in context.maticna
                                   where m.IdMaticne == ID
                                   select m).ToList().First();
                        komponenta = new komponenta();
                    }
                    else
                    {
                        komponenta = (from k in context.komponenta
                                      where k.IdKomponenta == ID
                                      select k).ToList().First();
                    }
                }
                
            string greska = "";
            if (txtNazivKomponente.Text == "" || txtProizvodac.Text == "" || txtCijena.Text == "" || txtPotrosnja.Text =="")
                greska = "Molimo popunite sva polja!";
            if (!int.TryParse(txtCijena.Text, out int cijena))
            {
                greska += "Cijena neispravnog formata!";
            }
            if(!int.TryParse(txtPotrosnja.Text, out int potrosnja))
                {
                    greska += "Potrošnja neispravnog formata!";
                }
            if (greska == "")
                {
                    komponenta.Tip = Tip;
                    komponenta.Proizvodac = txtProizvodac.Text;
                    komponenta.Cijena = int.Parse(txtCijena.Text);
                    komponenta.Naziv = txtNazivKomponente.Text;
                    komponenta.Potrosnja = int.Parse(txtPotrosnja.Text);
                    switch (Tip)
                    {
                        case "Procesor":
                            {
                                if (txtBrzina.Text == "" || txtSocekt.Text == "") greska = "Molimo popunite sva polja!";
                                if (greska == "")
                                {
                                    komponenta.Brzina = txtBrzina.Text;
                                    komponenta.Socket = txtSocekt.Text;
                                }
                                break;
                            }
                        case "Graficka":
                            {
                                if (txtInterface.Text == "" || txtDuzinaGraficke.Text == "" || txtVRAM.Text == "")
                                    greska = "Molimo popunite sva polja!";
                                if (greska == "")
                                {
                                    if (!double.TryParse(txtDuzinaGraficke.Text, out double duzina))
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
                                if (txtKapacitetNapajanja.Text == "") greska = "Molimo popunite sva polja!";
                                if (greska == "")
                                {
                                    if (!int.TryParse(txtKapacitetNapajanja.Text, out int kapacitet))
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
                        case "RAM":
                            {
                                if (txtTipMemorije.Text == "" || txtVelicinaMemorije.Text == "" || txtBrzina.Text == "")
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

                        case "Maticna":
                            {
                                if (txtSocekt.Text == "" || txtVelicinaMaticne.Text == "" || txtTipMemorije.Text == "" ||
                                    numBrojModula.Value == 0)
                                    greska = "Molimo popunite sva polja!";
                                if (greska == "")
                                {
                                    
                                    maticna.Proizvodac = txtProizvodac.Text;
                                    maticna.Cijena = int.Parse(txtCijena.Text);
                                    maticna.Naziv = txtNazivKomponente.Text;
                                    maticna.Potrosnja = int.Parse(txtPotrosnja.Text);
                                    maticna.Socket = txtSocekt.Text;
                                    maticna.Velicina = txtVelicinaMaticne.Text;
                                    maticna.Tip_memorije = txtTipMemorije.Text;
                                    maticna.Broj_modula_za_memoriju = Decimal.ToInt32(numBrojModula.Value);
                                    maticna.InterfacePCIe8 = Convert.ToInt16(chkPCIe8.Checked);
                                    maticna.InterfacePCIe16 = Convert.ToInt16(chkPCIe16.Checked);

                                }
                                break;
                            }
                    }

                    if (greska == "")
                    {
                        if(Tip == "Maticna")
                        {
                            if(ID == 0)
                            {
                                context.maticna.Attach(maticna);
                                context.maticna.Add(maticna);
                                context.SaveChanges();
                            }
                            else
                            {
                                context.maticna.AddOrUpdate(maticna);
                                context.SaveChanges();
                            }
                            
                        }
                        else
                        {
                            if (ID == 0)
                            {
                                context.komponenta.Attach(komponenta);
                                context.komponenta.Add(komponenta);
                                context.SaveChanges();
                            }
                            else
                            {
                                context.komponenta.AddOrUpdate(komponenta);
                                context.SaveChanges();
                            }
                        }
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(greska);
                    }



                }
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
            if(ID != 0)
            {
                
                    using (var context = new PI2233_DBEntities())
                        {if (Tip != "Maticna")
                            {
                        var query = (from k in context.komponenta
                                     where k.IdKomponenta == ID
                                     select k).ToList();
                        PopuniFormu(query);
                    }
                    else
                    {
                        var query = (from m in context.maticna
                                     where m.IdMaticne == ID
                                     select m).ToList();
                        PopuniFormu(query);
                    }
                }
            }
        }

        private void PopuniFormu(List<maticna> query)
        {
            foreach(maticna maticna in query)
            {
                txtProizvodac.Text = maticna.Proizvodac;
                txtCijena.Text = maticna.Cijena.ToString();
                txtNazivKomponente.Text = maticna.Naziv;
                txtPotrosnja.Text = maticna.Potrosnja.ToString();
                txtSocekt.Text = maticna.Socket;
                txtVelicinaMaticne.Text = maticna.Velicina;
                txtTipMemorije.Text = maticna.Tip_memorije;
                numBrojModula.Value = maticna.Broj_modula_za_memoriju;
                chkPCIe8.Checked = Convert.ToBoolean(maticna.InterfacePCIe8);
                chkPCIe16.Checked = Convert.ToBoolean(maticna.InterfacePCIe16); ;
            }
        }

        private void PopuniFormu(List<komponenta> query)
        {
            foreach (komponenta komponenta in query)
            {
                txtIDKomponente.Text = komponenta.IdKomponenta.ToString();
                txtVrstaKomponente.Text = Tip;
                txtNazivKomponente.Text = komponenta.Naziv;
                txtProizvodac.Text = komponenta.Proizvodac;
                txtPotrosnja.Text = komponenta.Potrosnja.ToString();
                txtSocekt.Text = komponenta.Socket;
                txtTipMemorije.Text = komponenta.Tip_memorije;
                txtBrzina.Text = komponenta.Brzina;
                txtVelicinaMemorije.Text = komponenta.Velicina_memorije;
                txtInterface.Text = komponenta.Interface;
                txtDuzinaGraficke.Text = komponenta.Duzina_graficke.ToString();
                txtVRAM.Text = komponenta.Vram;
                txtKapacitetNapajanja.Text = komponenta.Kapacitet_napajanja.ToString();
                txtMaxGraficka.Text = komponenta.Maksimalna_duzina_graficke.ToString();
                txtPodrzavanaMaticna.Text = komponenta.Podrzavana_maticna;
                txtKapacitetPohrane.Text = komponenta.KapacitetPohrane;
                txtCijena.Text = komponenta.Cijena.ToString();
            }
        }
    }
}
