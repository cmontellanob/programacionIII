using System;
using System.Windows.Forms;

namespace Circunferencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Circunferencia miCircunferencia = new Circunferencia();
            try
            {
                miCircunferencia.Radio = double.Parse(txtRadio.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtRadio.Text = "";
                txtRadio.Focus();
                return;
            }
            if (radCalcularArea.Checked)
                MessageBox.Show("Área = " + miCircunferencia.Calcular(miCircunferencia.CalcularArea));
            if (radCalcularPerimetro.Checked)
                MessageBox.Show("Perímetro = " + miCircunferencia.Calcular(miCircunferencia.CalcularPerimetro));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
