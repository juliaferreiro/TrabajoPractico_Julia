using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico_Julia
{
    public partial class Conversionmoneda : Form
    {
        public Conversionmoneda()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDolares.Text = ("");
            txtInput.Text = ("");
            txtPesos1.Text = ("");
            txtPesos2.Text = ("");
            TxtEuros.Text = ("");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pesos = Convert.ToDouble(txtInput.Text);

            double dolares = pesos * 880;
            double euros = pesos * 947.80;

            txtDolares.Text = Convert.ToString(dolares);
            TxtEuros.Text = Convert.ToString(euros);
            txtPesos1.Text = Convert.ToString(pesos);
            txtPesos2.Text = Convert.ToString(pesos);



        }
    }
}
