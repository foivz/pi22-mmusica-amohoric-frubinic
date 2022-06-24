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
    public partial class SloziRacunaloForm : Form
    {
        public SloziRacunaloForm()
        {
            InitializeComponent();
        }

        private void listBoxProcesor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private bool ProvjeraTipa(string droppedTip, string ispravanTip) 
        {
            string[] provjera = droppedTip.Split(':');
            if (provjera[1] != ispravanTip) 
            { 
                return false;

            }
            else
            {
                return true;
            }
        }
        private void listBoxProcesor_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "Procesor");
            if (!isValidType) 
            {
                listBoxProcesor.Items.Clear();
                MessageBox.Show("U ovu kućicu idu samo procesori!");
                checkBoxProcesor.Checked = false;
            }
            else
            {
                listBoxProcesor.Items.Clear();
                listBoxProcesor.Items.Add(droppedItem);
                checkBoxProcesor.Checked = true;
            }
            
        }

        private void listBoxRAM_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "RAM");
            if (!isValidType)
            {
                listBoxRAM.Items.Clear();
                MessageBox.Show("U ovu kućicu ide samo RAM memorija!");
                checkBoxProcesor.Checked = false;
            }
            else
            {
                listBoxRAM.Items.Clear();
                listBoxRAM.Items.Add(droppedItem);
                checkBoxRAM.Checked = true;
            }
        }

        private void listBoxRAM_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxGraficka_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxGraficka_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "Graficka");
            if (!isValidType)
            {
                listBoxGraficka.Items.Clear();
                MessageBox.Show("U ovu kućicu ide samo Graficka kartica!");
                checkBoxGraficka.Checked = false;
            }
            else
            {
                listBoxGraficka.Items.Clear();
                listBoxGraficka.Items.Add(droppedItem);
                checkBoxGraficka.Checked = true;
            }
        }

        private void listBoxPohrana_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxPohrana_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "Pohrana");
            if (!isValidType)
            {
                listBoxPohrana.Items.Clear();
                MessageBox.Show("U ovu kućicu ide samo Pohrana!");
                checkBoxPohrana.Checked = false;
            }
            else
            {
                listBoxPohrana.Items.Clear();
                listBoxPohrana.Items.Add(droppedItem);
                checkBoxPohrana.Checked = true;
            }
        }

        private void listBoxNapajanje_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxNapajanje_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "Napajanje");
            if (!isValidType)
            {
                listBoxNapajanje.Items.Clear();
                MessageBox.Show("U ovu kućicu ide samo Napajanje!");
                checkBoxNapajanje.Checked = false;
            }
            else
            {
                listBoxNapajanje.Items.Clear();
                listBoxNapajanje.Items.Add(droppedItem);
                checkBoxNapajanje.Checked = true;
            }
        }

        private void listBoxKuciste_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxKuciste_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "Kucista");
            if (!isValidType)
            {
                listBoxKuciste.Items.Clear();
                MessageBox.Show("U ovu kućicu ide samo Kuciste!");
                checkBoxKuciste.Checked = false;
            }
            else
            {
                listBoxKuciste.Items.Clear();
                listBoxKuciste.Items.Add(droppedItem);
                checkBoxKuciste.Checked = true;
            }
        }

        private void listBoxMaticna_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxMaticna_DragDrop(object sender, DragEventArgs e)
        {
            string droppedItem = e.Data.GetData(DataFormats.Text).ToString();
            bool isValidType = ProvjeraTipa(droppedItem, "Maticna");
            if (!isValidType)
            {
                listBoxMaticna.Items.Clear();
                MessageBox.Show("U ovu kućicu ide samo Maticna!");
                checkBoxMaticna.Checked = false;
            }
            else
            {
                listBoxMaticna.Items.Clear();
                listBoxMaticna.Items.Add(droppedItem);
                checkBoxMaticna.Checked = true;
            }
        }
    }
}
