using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenComboBox06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            txtbox1.Clear();
            txtbox1.AppendText("Odabrali ste:" + Environment.NewLine);
            if (chckboxDorucak.Checked) ;
                txtbox1.AppendText("Doručak" + Environment.NewLine);
            if (chckboxRucak.Checked)
                txtbox1.AppendText("Ručak" + Environment.NewLine);
            if (chckboxVecera.Checked)
                txtbox1.AppendText("Večera" + Environment.NewLine);

        }

        private void chckboxSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (txtbox1.Visible == false)
                txtbox1.Visible = true;
            else
                txtbox1.Visible = false;
        }
    }
}
