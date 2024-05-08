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
    public partial class Fotografia : Form
    {
        public Fotografia()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtInput.Text);

            if (cmbTipo.SelectedIndex == 1) 
            {
                if (rdb3x4.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 5.50);
                }
                else if (rdb4x6.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 6.20);
                }
                else if (rdb5x7.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 7.50);
                }
                else if (rdb6x8.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 9.00);
                }

            }

            else if (cmbTipo.SelectedIndex == 2)
            {
                if (rdb3x4.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 4.00);
                }
                else if (rdb4x6.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 5.20);
                }
                else if (rdb5x7.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 6.00);
                }
                else if (rdb6x8.Checked)
                {
                    txtPagar.Text = Convert.ToString(cantidad * 7.90);
                }

            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = ("");
            txtPagar.Text = ("");
            rdb3x4.Checked = false;
            rdb4x6.Checked = false;
            rdb5x7.Checked = false;
            rdb6x8.Checked = false;
            cmbTipo.SelectedIndex = 0;
            


        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
