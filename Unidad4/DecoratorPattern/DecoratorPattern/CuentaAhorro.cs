using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class CuentaAhorro:ICuentaBancaria
    {
    public void abrirCuenta(Cuenta c)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Se abrió una cuenta de Ahorros");
            Console.WriteLine("Cliente: " + c.getCliente());
        }

    }
}
