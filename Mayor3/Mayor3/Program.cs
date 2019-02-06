using System;

namespace Mayor3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Introduzca los valoresde los datos");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            Console.WriteLine(Mayor(x, y, z) + " es mayor");

            Char a, b, c;
            Console.WriteLine("Introduzca los valoresde los datos");
            a = 'E';
            b = 'D';
            c = 'A';
            Console.WriteLine(Mayor(a,b,c) + " es mayor");
            /*  if (x>y&&x>z)
            {
                Console.WriteLine(x + " es mayor");
            }
            else if(y>x&&y>z)
            {
                Console.WriteLine(y + " es mayor");
            }
            else if(z>x&&z>y)
            {
                Console.WriteLine(z + " es mayor");
            }*/
            Console.ReadKey();
        }
        static T Mayor<T>(T x,T y,T z) where T : IComparable<T>
        {
            T aux = x;
            if (y.CompareTo(aux) > 0) aux = y;
            if (z.CompareTo(aux) > 0) aux = z;
            return aux;

        }
        static int Mayor2(int x, int y, int z)
        {
            int aux =( x + y + z + Math.Abs(x - y) + Math.Abs(x - z) + Math.Abs(y - z))/3;
            return aux;

        }

    }
}
