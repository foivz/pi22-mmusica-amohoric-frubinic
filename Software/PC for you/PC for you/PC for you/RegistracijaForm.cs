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
                using (var context = new PI2233_DBEntities())
                {

                }
            }
            else
            {
                MessageBox.Show("Lozinke vam nisu iste! Molimo Vas da unesete opet");
            }
            
        }
    }
}
