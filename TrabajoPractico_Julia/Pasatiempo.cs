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
    public partial class Pasatiempo : Form
    {
        public Pasatiempo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chkLeer.Checked == true)
            { 
                txtPasatiempo.Text += ("Leer "); 
            }
            if (chkBailar.Checked == true) 
            {
                txtPasatiempo.Text += ("Bailar ");
            }
            if (chkComer.Checked == true) 
            {
                txtPasatiempo.Text += ("Comer ");
            }
            if (chkTV.Checked == true) 
            {
                txtPasatiempo.Text += ("Ver T.V ");
            }

        }
    }
}
