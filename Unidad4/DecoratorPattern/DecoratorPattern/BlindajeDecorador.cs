using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class BlindajeDecorador:CuentaDecorador
    {
        public BlindajeDecorador(ICuentaBancaria cDecorada) : base(cDecorada)
        {
           
        }

        public void abrirCuenta(Cuenta c)
        {
            cuentaDecorada.abrirCuenta(c);
            agregarBlindaje(c);
        }

        public void agregarBlindaje(Cuenta c)
        { 
        Console.WriteLine("Se agregó blindaje a la cuenta del cliente " + c.getCliente());
        }
    }
}
