using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ConexionBDFabrica:IFabricaAbstracta
    {
    public IConexionBD getBD(String motor)
        {
            if (motor=="MYSQL")
            {
                return new ConexionMySQL();
            }
            else 
            {
                return new ConexionSQLServer();
            }

            
        }

    public IConexionREST getREST(String area)
        {
            return null;
        }
    }
}
