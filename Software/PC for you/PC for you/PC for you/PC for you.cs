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
    public partial class PCForYouForm : Form
    {
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
    }
}
