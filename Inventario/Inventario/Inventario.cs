using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario
{
    class Inventario
    {
        public delegate void delegado(int n);
        public event delegado stockminimo;

        private int stock;
        public Inventario()
        {
            this.stock = 0;
        }
        public void incremetarstock(int n)
        {
            this.stock += n;
            if (this.stock<5 && stockminimo!=null)
            {
                stockminimo(this.stock);
            }
        }
        public void disminuirstock(int n)
        {
            if (this.stock < n)
            { Console.WriteLine("No se dispone de esa cantidad en el stock");
                Console.ReadKey();
            }
            else
            this.stock -= n;
            if (this.stock < 5 && stockminimo != null)
            {
                stockminimo(this.stock);
            }
        }
        public void mostrarstock()
        {
            Console.WriteLine("El estock actual es {0} ",this.stock);    
         }
    }
}
