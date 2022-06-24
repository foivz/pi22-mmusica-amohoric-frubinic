using System;
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
        public UCKosarica(List<komponenta> listaK, List<maticna> listaM)
        {
            listaMaticna = listaM;
            listaKomponenata = listaK;
            InitializeComponent();
        }

        private void UCKosarica_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            dgvKosarica.DataSource = null;
            dgvKosarica.DataSource = listaKomponenata;
        }
    }
}
