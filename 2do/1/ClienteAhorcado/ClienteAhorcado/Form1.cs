using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteAhorcado
{
    public partial class Form1 : Form
    {
        public const String ruta = "d:\\ProgramacionIII\\Ahorcado\\";
        public Form1()
        {
            InitializeComponent();
        }
        private void verificarEstado(int Estado)
        {
            switch (Estado)
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
                    
                    break;
            
            }
            if (Estado==8)
            {
                MessageBox.Show("Has Perdido");
            }
            if (!lblResultado.Text.Contains('-'))
            {
                MessageBox.Show("Has Ganado");
            }
        }
        public String EnviarMensaje(String cadena)
        {
            String Respuesta = "";
            byte[] bytes = new byte[1024];
            try
            {
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);
                // Crear un socket TCP/IP  .  
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    // de conecta al servidor
                    sender.Connect(remoteEP);
                    Console.WriteLine("Socket connectado a {0}",
                        sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(cadena);
                    // aqui se manda el mensaje
                    int bytesSent = sender.Send(msg);
                    // Recibe ladespuesta desde el dispositivo remoto .  
                    int bytesRec = sender.Receive(bytes);
                    
                    Respuesta = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        bytesRec = sender.Receive(bytes);

                    
                    

                    // libera el socket.  
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                    return Respuesta;

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error no manejado  : {0}", e.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return Respuesta;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = EnviarMensaje("letra:"+txtLetra.Text);
            int estado= int.Parse(EnviarMensaje("op:estado"));
            verificarEstado(estado);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResultado.Text= EnviarMensaje("op:iniciar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblResultado.Text = EnviarMensaje("palabra:" + txtPalabra.Text);
            int estado = int.Parse(EnviarMensaje("op:estado"));
            verificarEstado(estado);
        }
    }
}
