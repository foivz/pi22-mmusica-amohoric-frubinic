﻿using System;
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
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            string greska = "";
            if (txtKorime.Text.Equals("")) greska += "Korisničko ime nije uneseno!";
            if (txtLozinka.Text.Equals("")) greska += "Lozinka nije unesena!";
            if (greska.Equals(""))
            {

            }
            else
            {
                MessageBox.Show(greska);
            }
        }
    }
}
