using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class frmAhorcado : Form
    {
        public frmAhorcado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ahorcado.getInstancia().Iniciar();
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtPalabra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text= Ahorcado.getInstancia().Buscar(txtLetra.Text[0]);
        }
    }
}
