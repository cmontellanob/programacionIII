using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonaci(1) = {0}",fibonaci(n));
          //  Console.WriteLine("Fibonaci(5) = {0}", fibonaci(5));
         //   Console.WriteLine("Fibonaci(3) = {0}", fibonaci(3));
            Console.ReadKey();
        }
        public static int fibonaci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibonaci(n - 1) + fibonaci(n - 2);
            }
           

        }
    }
}
