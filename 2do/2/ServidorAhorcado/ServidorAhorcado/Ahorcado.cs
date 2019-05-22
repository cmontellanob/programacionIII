using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorAhorcado
{
    class Ahorcado
    {
        private String PalabraAdivinar;
        private List<char> Letras;
        public int Estado { get; private set; }
        private String Guiones;
        private static Ahorcado Instancia;  //singleton
        private Ahorcado() { //singleton
            
        }
        public void setPalabraAdivinar(String valor)
            {
            PalabraAdivinar = valor;
            }
        public void Iniciar()
        {
            Estado = 0;
            Letras = new List<char>();
            Guiones = "";
            Guiones=Guiones.PadLeft(PalabraAdivinar.Count(), '-');
        }
        
        public String Buscar(char Letra)
        {
            Letras.Add(Letra);
            String aux = "";
            if (PalabraAdivinar.Contains(Letra.ToString()))
            {
                for (int i=0;i< PalabraAdivinar.Count();i++)
                {
                    
                    if (PalabraAdivinar[i]==Letra)
                    {
                        aux += Letra; 
                    }
                    else
                    {
                        aux += Guiones[i];
                    }
                }
                Guiones = aux;
                return aux;
                
            }
            else
            {
                Estado++;
                return Guiones;             }
        }
        public String BuscarPalabra(String Palabra)
        {
            if (Palabra == PalabraAdivinar)
            {
                Guiones = PalabraAdivinar;
            }
            else
            {
                Estado++;
            }
            return Guiones;
            
        }
        public int getEstado()
        {
            return Estado;
        }
        public String getGuiones()
        {
            return Guiones;
        }


        public static Ahorcado getInstancia() //singleton
        {
            if (Instancia == null)
            {
                Instancia = new Ahorcado();
            }
            return Instancia;
        }

    }
}
