using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabricaAbstracta fabricaBD = FabricaProductor.getFactory("BD");
            IConexionBD cxBD1 = fabricaBD.getBD("MYSQL");

            cxBD1.conectar();

            IFabricaAbstracta fabricaREST = FabricaProductor.getFactory("REST");
            IConexionREST cxRS1 = fabricaREST.getREST("COMPRAS");

            cxRS1.leerURL("https://www.youtube.com/subscription_center?add_user=mitocode");
            Console.ReadKey();
        }
    }
}
