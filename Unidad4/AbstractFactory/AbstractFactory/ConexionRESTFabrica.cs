using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConexionRESTFabrica:IFabricaAbstracta
    {
       

        public IConexionREST getREST(String area)
        {
            if (area.Equals("COMPRAS"))
            {
                return new ConexionRESTCompras();
            }
            else
            { 
                return new ConexionRESTVentas();
            }


        }

    public IConexionBD getBD(String motor)
        {
            return null;
        }
    }
}
