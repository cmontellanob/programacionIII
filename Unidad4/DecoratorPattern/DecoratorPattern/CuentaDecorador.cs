using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class CuentaDecorador:ICuentaBancaria
    {
        

    protected ICuentaBancaria cuentaDecorada;

    public CuentaDecorador(ICuentaBancaria cDecorada)
        {
            cuentaDecorada = cDecorada;
        }

        public void abrirCuenta(Cuenta c)
        {
            cuentaDecorada.abrirCuenta(c);
        }

    }

}

