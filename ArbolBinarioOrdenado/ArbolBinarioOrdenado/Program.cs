using System;

namespace ArbolBinarioOrdenado
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol abo = new Arbol();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Impresion preordenorden: ");
            abo.PreOrden(abo.raiz);
            Console.WriteLine("Impresion Simetrico: ");
            abo.Simetrico(abo.raiz);
            Console.WriteLine("Impresion postorden: ");
            abo.PostOrden(abo.raiz);
            Console.ReadKey();
        }
    }
}
