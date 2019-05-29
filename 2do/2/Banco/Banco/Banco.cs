using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        Double Cotizacion;
        static Banco Instancia;
        private Banco()
        {

        }
        public static Banco getInstancia()
        {
            if (Instancia == null)
                Instancia = new Banco();
            return Instancia;
        }
        public Double ObtenerCotizacion()
        {
            return Cotizacion;
        }
        public void ColocarCotizacion(Double Valor)
        {
            Cotizacion = Valor;        }

    }
}
