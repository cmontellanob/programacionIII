using System;
using System.Threading;
using System.Threading.Tasks;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int x = 0;
            pila<int> p = new pila<int>();
            Thread hilo = new Thread(new ThreadStart(calcular));
            hilo.Start();
            while (opcion !=4)
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
                        p.push(x);
                        break;
                    case 2:
                        x = p.pop();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }
            hilo.Join();

        }
        public static void calcular()
        {
            int sum = 0;
            for (int i=0;i<=10000;i++)
            {
                Thread.Sleep(10);
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
