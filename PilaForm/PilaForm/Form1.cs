using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        pila<string> pi = new pila<string>();
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            pi.push(Txtinsertar.Text); 

        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            lblvalor.Text = pi.pop();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            mostrar.Items.Clear();
            string[] are = pi.mostrar();
            for(int i=0;i<are.Length;i++)
            {
                mostrar.Items.Add(are[i]);
            }

        }

        private void btnmosdin_Click(object sender, EventArgs e)
        {
            int arriba = 0;
            panel1.Controls.Clear();
            string[] are = pi.mostrar();
            for (int i = 0; i < are.Length; i++)
            {
                Label lbl = new Label();
                lbl.Top = arriba;
                arriba += 25;
                lbl.Text = are[i];
                panel1.Controls.Add(lbl);
                
            }
        }
    }
}
