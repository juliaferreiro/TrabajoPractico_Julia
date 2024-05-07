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
    public partial class EstadoCivil : Form
    {
        public EstadoCivil()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbSoltero.Checked == true)
            {
                txtPasatiempo.Text = ("Soltero ");
            }
            if (rdbCasado.Checked == true)
            {
                txtPasatiempo.Text = ("Casado ");
            }
            if (rdbViudo.Checked == true)
            {
                txtPasatiempo.Text = ("Viudo ");
            }
            if (rdbDivorciado.Checked == true)
            {
                txtPasatiempo.Text = ("Divorciado ");
            }
            if (rdbUnionLibre.Checked == true)
            {
                txtPasatiempo.Text = ("UnionLibre ");
            }
        }
    }
}
