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
    public partial class Medidas : Form
    {
        public Medidas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtKilogramos.Text = ("");
            txtLibras.Text = ("");
            txtGramos.Text = ("");
            txtDecagramos.Text = ("");
            txtOnzas.Text = ("");
            txtMiligramos.Text = ("");
            txtToneladas.Text = ("");
            txtToneladasMetricas.Text = ("");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double kilos = Convert.ToDouble(txtKilogramos.Text);

            double libras = kilos * 2.20462;
            double gramos = kilos * 1000;
            double decagramos = kilos * 100;
            double onzas = kilos * 35.2740;
            double miligramos = kilos * 1000000;
            double tonelada = kilos * 0.001;
            double toneladaMetrica = kilos * 0.98;

            txtLibras.Text = Convert.ToString(libras);
            txtGramos.Text = Convert.ToString(gramos);
            txtDecagramos.Text = Convert.ToString(decagramos);
            txtOnzas.Text = Convert.ToString(onzas); 
            txtMiligramos.Text = Convert.ToString(miligramos);
            txtToneladas.Text = Convert.ToString(tonelada);
            txtToneladasMetricas.Text = Convert.ToString(toneladaMetrica);
        }
    }
}
