using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IFabricaAbstracta
    {
        IConexionBD getBD(String motor);
        IConexionREST getREST(String area);
    }

}
