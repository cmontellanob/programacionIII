using System;

namespace Fibonacci
{
    class Program
    {
        delegate int operacion(int n);
        static void Main(string[] args)
        {
            operacion fibonaci=null;
            fibonaci = (n) => {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else return fibonaci(n-2)+ fibonaci(n-1); };
            Console.WriteLine(fibonaci(6));
            Console.ReadKey();
        }
    }
}
