using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorAhorcado

{
    class Program
    {
        // Datos Recibidos Desde ElCliente.  
        public static string data = null;

        public static void StartListening()
        {
            // Bufer de Datos paralosdatos recibidos  
            Console.WriteLine("Introduzca una palabra");
            String Palabra = Console.ReadLine();
            Ahorcado.getInstancia().setPalabraAdivinar(Palabra);
            Ahorcado.getInstancia().Iniciar();
            byte[] bytes = new Byte[1024];

            // Establece el punto deentrada final para el socket.  
            // Dns.GetHostName devuelve el nombre del host donde correr la aplicacion
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            //IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            // Crea un Socket TCP/IP x.  
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Inicia a escuchas miestras llegan conexiones.  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    // el Programa es suspendido mientras espera oconexiones de entrada .  
                    Socket handler = listener.Accept();
                    data = null;

                    // La conexion de entrada necesita ser procesada.  
                        int bytesRec = handler.Receive(bytes);
                        data = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    String respuesta = "";
                    String[] envio = data.Split(':');
                    if (envio[0]=="op")
                    {
                        if (envio[1]=="iniciar")
                        {
                            Ahorcado.getInstancia().Iniciar();
                            respuesta = Ahorcado.getInstancia().getGuiones();
                        }
                      if (envio[1] == "estado")
                        {
                            respuesta = Ahorcado.getInstancia().getEstado().ToString();
                        }
                    }
                    if (envio[0] == "letra")
                    {
                        respuesta = Ahorcado.getInstancia().Buscar(envio[1][0]);
                    }
                    if (envio[0] == "palabra")
                    {
                        respuesta = Ahorcado.getInstancia().BuscarPalabra(envio[1]);
                    }




                    // Muestra los datos en la consola .  
                    Console.WriteLine("Texto recibido: {0}", data);
                    // Muestra los datos en la consola .  
                    Console.WriteLine("Texto enviado: {0}", respuesta);

                    // Prepara los datos para responder  al cliente.  
                    byte[] msg = Encoding.ASCII.GetBytes(respuesta);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}

