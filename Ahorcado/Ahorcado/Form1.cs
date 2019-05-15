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
        public const String ruta = "d:\\ProgramacionIII\\Ahorcado\\";
        public frmAhorcado()
        {
            InitializeComponent();
        }
        private void verificarEstado()
            {
            switch (Ahorcado.getInstancia().Estado)
            {
                case 0:
                    pbImagen.Image = null;
                    break;
                case 1:

                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "1.png");
                    break;
                case 2:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "2.png");
                    break;
                case 3:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "3.png");
                    break;
                case 4:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "4.png");
                    break;
                case 5:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "5.png");
                    break;

                case 6:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "6.png");
                    break;
                case 7:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "7.png");
                    break;
                case 8:
                    pbImagen.Image = new System.Drawing.Bitmap(ruta + "8.png");
                    MessageBox.Show("Usted  ha perdido");
                    Ahorcado.getInstancia().Iniciar();
                    break;

            }
            if (!lblResultado.Text.Contains('-'))
            {
                MessageBox.Show("Has Ganado");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Ahorcado.getInstancia().Iniciar();
            pbImagen.Image = null;
            lblResultado.Text = "-";

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
            
            verificarEstado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Ahorcado.getInstancia().BuscarPalabra(txtPalabra.Text);

            verificarEstado();

        }
    }
}
