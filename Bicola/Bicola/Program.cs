using System;

namespace Bicola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            BiCola<int> p = new BiCola<int>();
            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por Detras");
                Console.WriteLine("2. Insertar por Delante");
                Console.WriteLine("3. Eliminar por Delante");
                Console.WriteLine("4. Eliminar por Atras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento Atras");
                        x = int.Parse(Console.ReadLine());
                        p.InsertarAtras(x);
                        break;
                    case 2:
                        Console.WriteLine("introduzca un elemento DElante");
                        x = int.Parse(Console.ReadLine());
                        p.InsertarDelante(x);
                        break;
                    case 3:
                        x = p.EliminarDelante();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 4:
                        x = p.EliminarAtras();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }


            }
        }
    }
}