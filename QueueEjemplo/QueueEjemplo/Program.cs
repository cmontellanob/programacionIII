using System;
using System.Collections;

namespace QueueEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            Queue c = new Queue() ;
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x = int.Parse(Console.ReadLine());
                        c.Enqueue(x);
                        
                        break;
                    case 2:
                        x = (int)c.Dequeue();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 3:
                        foreach (object o in c)
                        {
                            Console.Write("{0 }",o);
                        }
                        
                        Console.ReadKey();
                        break;

                }

            }
        }
    }
}
