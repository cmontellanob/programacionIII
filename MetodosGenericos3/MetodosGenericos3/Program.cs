using System;

namespace MetodosGenericos3
{
    class Program
    {
        static void Main(string[] args)
        {
            string maxString = Maximo<string>("Carlos", "Pedro");
            Console.WriteLine(maxString);
            int maxInt = Maximo<int>(2, 99);
            Console.WriteLine(maxInt);
            Console.ReadKey();
        }
        public static T Maximo<T>(T uno, T otro) where T : IComparable
        {
            if (uno.CompareTo(otro) > 0) return uno;
            return otro;
        }
    }
}


