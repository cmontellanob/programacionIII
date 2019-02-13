using System;

namespace Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inv = new Inventario();
            inv.stockminimo += loquequieran;
            int n;
            Boolean salir = false;
            int op = 0;
            //while (salir == false)
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Incrementar");
                Console.WriteLine("2.- Dismunir");
                Console.WriteLine("3.- Mostrar");
                Console.WriteLine("4.- Salir");
                Console.WriteLine("Elegir un opion");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("introduzca n ");
                        n = int.Parse(Console.ReadLine());
                        inv.incremetarstock(n);
                        break;
                    case 2:
                        Console.Write("introduzca n ");
                        n = int.Parse(Console.ReadLine());
                        inv.disminuirstock(n);
                        break;
                    case 3:
                        inv.mostrarstock();
                        Console.ReadKey();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("opcion no valida");
                        break;
                }
            } while (op != 4);
                

        }
        static void loquequieran(int n)
        {
            Console.WriteLine("El estock esta en su minimo {0}",n);
            Console.ReadKey();
        }
    }
}
