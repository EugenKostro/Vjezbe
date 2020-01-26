using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kostroEugenRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (rBtnAvion.Checked)
                textBox1.Text = "Odabrali ste avion";
            else if (rBtnAutobus.Checked)
                textBox1.Text = "Odabrali ste autobus";
            else if (rBtnVlastiti.Checked)
                textBox1.Text = "Odabrali ste vlastiti prijevoz";
            else
            {
                MessageBox.Show("Odaberite vrstu prijevoza!");
                return;
                
            }
        }
    }
}
