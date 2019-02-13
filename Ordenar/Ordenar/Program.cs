using System;
namespace Ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            Console.WriteLine("Entra els nombres");
            for (int x = 0; x < 3; x++)
            {
                array1[x] = int.Parse(Console.ReadLine());
            }
            ordena1(array1);
            string[] vector= {"uno","dos","tres" };

            ordena1(vector);

            Console.ReadKey();
        }


        static void ordena1<U>(U[] array2)
        {
            Array.Sort(array2);

            Console.WriteLine("numeros");
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine(array2[x]);

            }
            
        }


        


    }
}
