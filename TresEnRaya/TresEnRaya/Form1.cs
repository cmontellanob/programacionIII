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
        const String rutax= "D:\\X.png";
        const String rutaO = "D:\\O.png";
        public void AnalizaMensage(String mensaje)
        {
            String[] respuesta = mensaje.Split(':');
            switch (respuesta[0])
            {
                case "ganador":
                    lblMensaje.Text = "el ganador es: " + respuesta[1];
                    break;
                case "continuar":
                    if (lblTurno.Text == "x")
                        lblTurno.Text = "o";
                    else
                        lblTurno.Text = "x";
                    break;
                case "error":
                    lblMensaje.Text = "error: " + respuesta[1];
                    break;
                case "resultado":
                    lblMensaje.Text = "ha habido un empate";

                    break;

            }
        }
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
            pb00.Image = null;
            pb01.Image = null;
            pb02.Image = null;
            pb10.Image = null;
            pb11.Image = null;
            pb12.Image = null;
            pb20.Image = null;
            pb21.Image = null;
            pb22.Image = null;
            lblTurno.Text = "x";
            lblMensaje.Text= "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String respuesta= Raya.getInstancia().marcar(0,0, lblTurno.Text[0]);
            if (lblTurno.Text=="x")
                pb00.Image= new System.Drawing.Bitmap(rutax);
            else
                pb00.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb01_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(0, 1, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb01.Image = new System.Drawing.Bitmap(rutax);
            else
                pb01.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb02_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(0, 2, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb02.Image = new System.Drawing.Bitmap(rutax);
            else
                pb02.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(1, 0, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb10.Image = new System.Drawing.Bitmap(rutax);
            else
                pb10.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(1, 1, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb11.Image = new System.Drawing.Bitmap(rutax);
            else
                pb11.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(1, 2, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb12.Image = new System.Drawing.Bitmap(rutax);
            else
                pb12.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(2, 0, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb20.Image = new System.Drawing.Bitmap(rutax);
            else
                pb20.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb21_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(2, 1, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb21.Image = new System.Drawing.Bitmap(rutax);
            else
                pb21.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }

        private void pb22_Click(object sender, EventArgs e)
        {
            String respuesta = Raya.getInstancia().marcar(2, 2, lblTurno.Text[0]);
            if (lblTurno.Text == "x")
                pb22.Image = new System.Drawing.Bitmap(rutax);
            else
                pb22.Image = new System.Drawing.Bitmap(rutaO);
            AnalizaMensage(respuesta);
        }
    }
}
