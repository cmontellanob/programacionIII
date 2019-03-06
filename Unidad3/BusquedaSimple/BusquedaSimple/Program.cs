using System;

namespace BusquedaSimple
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arreglo = new int [10] {54,26,93,17,77,31,44,55,20,65};
            seleccion(arreglo);
            mostrar(arreglo);
            int b = int.Parse(Console.ReadLine());
            if (buscar(arreglo, b))
                Console.WriteLine("Se encontro elelemnto");
            else
                Console.WriteLine("No se encontro el elemento");

            Console.ReadKey();
        }
        static Boolean buscar(int[] arreglo,int b)
        {
            int i = 0;
            while (b > arreglo[i] && i<=arreglo.Length)
            {
                i++;
            }
            if (b == arreglo[i])
                return true;
            else
                return false;
        }

        static Boolean buscarbinario(int[] arreglo, int b)
        {
            int i = 0;
            int j = arreglo.Length - 1;
            int m = (j - i) / 2 + 1;

            while (b != arreglo[i] && j > (i+1))
            {
                if (b > arreglo[m])
                    i = m;
                else
                    j = m;
                m = (j - i) / 2 + 1;
            }
            if (b == arreglo[m])
                return true;
            else
                return false;
        }
        static void mostrar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
        }



        static void seleccion(int[] arreglo)
        {
            int aux = 0;
            for (int i=0;i<arreglo.Length; i++)
            {
                for (int j = i+1; j < arreglo.Length; j++)
                {
                    if (arreglo[i]>arreglo[j])
                    {
                        aux = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = aux;
                    }
                }
            }
        }
    }
}
