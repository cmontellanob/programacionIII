using System;

namespace Bicola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Docente x;
            BiCola<Docente> p = new BiCola<Docente>();
            

            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("1. Insertar por Detras");
                Console.WriteLine("2. Insertar por Delante");
                Console.WriteLine("3. Eliminar por Delante");
                Console.WriteLine("4. Eliminar por Atras");
                Console.WriteLine("5. Mostrar");
                Console.WriteLine("6. Salir");

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
                        p.InsertarAtras(new Docente(nom, ed, sex, carr)); break;
                        
                        break;
                    case 2:
                        Console.WriteLine("introduzca un elemento DElante");
                        Console.WriteLine("introduzca un Nombre");
                        String nom2 = Console.ReadLine();
                        Console.WriteLine("introduzca un Edad");
                        int ed2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("introduzca un Sexo");
                        String sex2 = Console.ReadLine();
                        Console.WriteLine("introduzca un Carrera");
                        String carr2 = Console.ReadLine();
                        p.InsertarDelante(new Docente(nom2, ed2, sex2, carr2));
                        break;
                    case 3:
                        x = p.EliminarDelante();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 4:
                        x = p.EliminarAtras();
                        Console.WriteLine("El elemento eliminado es {0}", x);
                        Console.ReadKey();
                        break;
                    case 5:
                        p.mostrar();
                        Console.ReadKey();
                        break;

                }


            }
        }
    }
}