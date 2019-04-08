using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
                Cuenta c = new Cuenta(1, "MitoCode");

                ICuentaBancaria cuenta = new CuentaAhorro();
                ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuenta);

                cuenta.abrirCuenta(c);
                cuentaBlindada.abrirCuenta(c);
            Console.ReadLine();
           
        }
    }
}
