using System;
using System.Collections;

namespace StackEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            Stack p = new Stack();

            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un elemento");
                        x = int.Parse(Console.ReadLine());
                        p.Push(x);
                        break;
                    case 2:
                        x = (int)p.Pop();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 3:
                        foreach (Object o in p)
                        {
                            Console.WriteLine("{0}",o);
                        }
                            Console.ReadKey();
                        break;

                }

            }
        }
    }
}
