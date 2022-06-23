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
    }
}
