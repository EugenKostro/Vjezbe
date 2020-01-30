using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenContextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LijevoNaDesnoCTRLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxLijevo.Text = txtBoxDesno.Text;
        }

        private void DesnoNaLijevoCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBoxDesno.Text = txtBoxLijevo.Text;
        }
    }
}
