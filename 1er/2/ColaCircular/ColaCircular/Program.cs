using System;

namespace ColaCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Docente x ;  
            ColaCircular<Docente> p = new ColaCircular<Docente>();
            while (opcion != 4)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar");
                Console.WriteLine("2. Eliminar");
                Console.WriteLine("3. Mostrar");
                Console.WriteLine("4. Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("introduzca un Nombre");
                        String nom = Console.ReadLine();
                        Console.WriteLine("introduzca un Edad");
                        int ed = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca un Sexo");
                        String sex = Console.ReadLine();
                        Console.WriteLine("introduzca un Carrera");
                        String carr = Console.ReadLine();
                        p.Insertar(new Docente(nom, ed, sex, carr));                        break;
                    case 2:
                        x = p.Eliminar();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 3:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }

            }

        }
    }
}
