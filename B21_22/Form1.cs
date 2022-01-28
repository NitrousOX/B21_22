using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B21_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KrajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadnaMestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radna_mesta a = new Radna_mesta();
            a.Show();
        }

        private void NezavrseniProjektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projekti a = new Projekti();
            a.Show();
        }
    }
}
