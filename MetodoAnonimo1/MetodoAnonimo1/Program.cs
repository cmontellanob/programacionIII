using System;

namespace MetodoAnonimo1
{
    class Program
    {
        delegate int operaciones(int n);  
        static void Main(string[] args)
        {

            operaciones Factorial = delegate (int n)
              {
                  int fact = 1;
                  for (int i = 2; i <= n; i++)
                      fact *= i;
                  return fact;
              };
             operaciones Sumatoria = delegate (int n)
              {
                  int sum=0;
                  for (int i = 1; i <= n; i++)
                      sum+= i;
                  return sum;
              };
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Sumatoria(5));



            Console.ReadKey();

        }
    }
}
