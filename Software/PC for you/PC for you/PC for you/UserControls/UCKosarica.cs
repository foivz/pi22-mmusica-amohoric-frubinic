﻿using System;
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
    public partial class UCKosarica : UserControl
    {
        private List<komponenta> listaKomponenata;
        private List<maticna> listaMaticna;
        private static List<KomponentaZaKosaricu> listaKomponenataZaKosaricu = new List<KomponentaZaKosaricu>();
        public UCKosarica(List<komponenta> listaK, List<maticna> listaM)
        {
            listaMaticna = listaM;
            listaKomponenata = listaK;
            InitializeComponent();
        }

        private void UCKosarica_Load(object sender, EventArgs e)
        {
            NapuniListuKomponenataKosarice();
            RefreshDGV();
        }

        private void NapuniListuKomponenataKosarice()
        {
            listaKomponenataZaKosaricu.Clear();
            foreach (komponenta item in listaKomponenata)
            {
                KomponentaZaKosaricu novaKomponenta = new KomponentaZaKosaricu
                {
                    ID = item.IdKomponenta,
                    Naziv = item.Naziv,
                    Proizvodac = item.Proizvodac,
                    Tip = item.Tip,
                    Potrosnja = item.Potrosnja,
                    Cijena = item.Cijena

                };
                listaKomponenataZaKosaricu.Add(novaKomponenta);
            }
            foreach (maticna item in listaMaticna)
            {
                KomponentaZaKosaricu novaKomponenta = new KomponentaZaKosaricu
                {
                    ID = item.IdMaticne,
                    Naziv = item.Naziv,
                    Proizvodac = item.Proizvodac,
                    Tip = "Maticna",
                    Potrosnja = item.Potrosnja,
                    Cijena = item.Cijena

                };
                listaKomponenataZaKosaricu.Add(novaKomponenta);
            }
        }

        private void RefreshDGV()
        {
            dgvKosarica.DataSource = null;
            dgvKosarica.DataSource = listaKomponenataZaKosaricu;
            int duljinaDgv = dgvKosarica.Rows.Count;
            double kolicina=0;
            for (int i = 0; i < duljinaDgv; i++)
            {
                kolicina += double.Parse(dgvKosarica.Rows[i].Cells[4].Value.ToString());
            }
            tboxUkupno.Text=kolicina.ToString();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            OcistiKosaricu();
            MessageBox.Show("Vaša narudžba je otkazana");
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            KreacijaNarudzbe kreacijaNarudzbe = new KreacijaNarudzbe();
            int duljinaDgv = dgvKosarica.Rows.Count;
            
            for (int i = 0; i < duljinaDgv; i++)
            {
                int id = int.Parse(dgvKosarica.Rows[i].Cells[0].Value.ToString());
                string tip = dgvKosarica.Rows[i].Cells[5].Value.ToString();
            
                kreacijaNarudzbe.DodajKomponentuZaNarudzbu(new KreacijaNarudzbe(id, tip));
            }
            kreacijaNarudzbe.NaruciKomponente();
            OcistiKosaricu();
            MessageBox.Show("Uspješno ste naručili željene komponente!");
        }
        private void OcistiKosaricu() 
        {
            listaKomponenataZaKosaricu.Clear();
            listaKomponenata.Clear();
            listaMaticna.Clear();
            tboxUkupno.Clear();
            RefreshDGV();
        }
    }
}
