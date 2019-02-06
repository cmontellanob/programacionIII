using System;

namespace LambdaGenericos
{
    class Program
    {
        private delegate double Mathematical<T>(T value);

        public static void Main(string[] args)
        {
            Console.WriteLine("Empezando");
            Console.WriteLine();

            Mathematical<double> Doblar = (double value)=> { return Math.Pow(value, 2); };
            Mathematical<int> Mitad =  (int value)=> { return value / 2; };

            Console.WriteLine(Doblar(3.5));
            Console.WriteLine(Mitad(3));

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para cerrar");
            Console.ReadKey();
        }
    }
}
