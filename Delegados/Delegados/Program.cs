using System;

namespace Delegados
{
    delegate void Mdelegado();
    class Program
    {
        static void Main(string[] args)
        {
            Mdelegado del = new Mdelegado(Metodo1);
            del();
            Console.ReadKey();
        }
        static void Metodo(string p)
        {
            Console.WriteLine("Ejecutando Metodo");

        }
        static void Metodo1()
        {
            Console.WriteLine("Ejecutando Metodo 1");

        }

    }
}


