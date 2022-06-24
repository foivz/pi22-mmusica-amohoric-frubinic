using PC_for_you.UserControls;
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
    public partial class PocetnaStranicaForm : Form
    {
        private int uloga;
        private string korime;
        public PocetnaStranicaForm(int uloga, string korime)
        {
            InitializeComponent();
            this.uloga = uloga;
            this.korime = korime;
        }

        private void PocetnaStranicaForm_Load(object sender, EventArgs e)
        {
            UCKomponente ucKomponente = new UCKomponente();
            AddUserControl(ucKomponente);
            PrikaziSakrijNavigaciju();
        }

        private void PrikaziSakrijNavigaciju()
        {
            if (uloga == 1)
            {
                btnSveNarudzbe.Visible = true;
                btnUredivanjeKomponenata.Visible = true;
            }
            else
            {
                btnSveNarudzbe.Visible = false;
                btnUredivanjeKomponenata.Visible = false;
            }

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKomponente_Click(object sender, EventArgs e)
        {

            UCKomponente ucKomponente = new UCKomponente();
            AddUserControl(ucKomponente);
        }
        private void AddUserControl(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
    }
}
