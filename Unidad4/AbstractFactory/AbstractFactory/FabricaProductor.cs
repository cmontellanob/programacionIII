using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FabricaProductor
    {
        public static IFabricaAbstracta getFactory(String tipoFabrica)
        {

            if (tipoFabrica.Equals("BD"))
            {
                return new ConexionBDFabrica();

            }
            else if (tipoFabrica.Equals("REST"))
            {
                return new ConexionRESTFabrica();
            }

            return null;
        }
    }
}
