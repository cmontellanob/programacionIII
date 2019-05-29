using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima
{
    class Clima
    {
        double Temperatura;
        static Clima Instancia;

     private Clima()
        {

        }
     public static Clima getInstance()
        {
            if (Instancia == null)
                Instancia = new Clima();
            return Instancia;
        }
     public double obtenertemperatura()
        {
            return Temperatura;
        }
      public void colocarTemperatura(Double valor)
        {
            Temperatura = valor;
        }
    }
}
