using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TresEnRaya
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

        private void button1_Click(object sender, EventArgs e)
        {
            Raya.getInstancia().Reiniciar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String respuesta= Raya.getInstancia().marcar(0,0, lblTurno.Text[0]);
            if (lblTurno.Text=="X")
                pb00.Image= new System.Drawing.Bitmap("D:\\X.png");
            else
                pb00.Image = new System.Drawing.Bitmap("D:\\O.png");
        }
    }
}
