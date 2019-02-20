using System;
using System.Linq;

namespace ConMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona[] Alumnos = new Persona[7];
            Alumnos[0] = new Persona("Diego", "La Torre", 18, "Masculino", "13121920", 1.74, 76);
            Alumnos[1] = new Persona("Diego", "Castro", 19, "Masculino", "7483306", 1.69, 70);
            Alumnos[2] = new Persona("Isabel", "Lopez", 19, "Femenino", "7504259", 1.65, 60);
            Alumnos[3] = new Persona("Rossimar", "Guzman", 18, "Femenino", "5713604", 1.54, 40);
            Alumnos[4] = new Persona("Franco", "Adamczyk", 18, "Masculino", "12609597", 1.74, 62);
            Alumnos[5] = new Persona("Gustavo", "Zarate", 19, "Masculino", "12575699", 1.76, 60);
            Alumnos[6] = new Persona("Dieter", "Quiñones", 19, "Masculino", "7547264", 1.67, 57);
            Console.WriteLine("Con metodos ");
            // sintaxis metodo
            Console.WriteLine("1.- lista detodos los alumnos");
            var metodo1 = Alumnos;

            foreach (Persona p in metodo1)
            {
                Console.WriteLine("{0} {1} {2} {3} ", p.Nombre, p.Apellidos, p.Edad, p.Sexo);
            }
            Console.WriteLine("***");

            Console.WriteLine("2.- lista de los alumnos cuya edad sea mayora 18");

            var metodo2 = Alumnos.Where(d => d.Edad > 18);

            foreach (Persona p in metodo2)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }

            Console.WriteLine("***");

            Console.WriteLine("3.- lista de alumnos ordenada por apellidos");
            // 
            var metodo3 = Alumnos.OrderBy(p => p.Apellidos);
                            
            foreach (var p in metodo3)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }

            Console.WriteLine("***");

            Console.WriteLine("4.- lista de alumnos ordenada por nombre luego por apellido descendentemente");
            //
            var metodo4 = Alumnos.OrderBy(p => p.Nombre).ThenByDescending(p => p.Apellidos);
                            
            foreach (var p in metodo4)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }

            Console.WriteLine("***");

            Console.WriteLine("5.- Lista de Alumnos Agrupadas por Edades ");

            //
            var metodo5 = Alumnos.GroupBy(p => p.Edad); 
                            
            // Grupo Edades
            foreach (var GrupoEdades in metodo5)
            {
                Console.WriteLine(GrupoEdades.Key);
                foreach (Persona alumno in GrupoEdades)
                {
                    Console.WriteLine("{0} {1}", alumno.Nombre, alumno.Apellidos);

                }
            }
            Console.WriteLine("********************************");
            //
            Console.WriteLine("6.- Cantidad de  alumnos por edad ");

            var metodo6 = Alumnos.GroupBy(t => new { Edad = t.Edad })
                         .Select(g => new {
                             Cantidad = g.Count(), Edad = g.Key.Edad});
            
            foreach (var grupoedad in metodo6)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);

            }
            Console.WriteLine("***");
            //
            Console.WriteLine("7.- Promedio de Edad por Sexo ");

            var metodo7 = Alumnos.GroupBy(p => new { Sexo = p.Sexo })
                            .Select(h => new { Sexo = h.Key, Promedio = h.Average(q => q.Edad) });
                            
            foreach (var grupoedad in metodo7)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Promedio);

            }
            Console.WriteLine("***");
            Console.WriteLine("8.- Las personas mas alta por sexo  ");

            var metodo8 = Alumnos.GroupBy(p => new { Sexo = p.Sexo })
                            .Select(q => new { Sexo = q.Key, Altura = q.Max(r => r.Altura) });
                            
            foreach (var gruposexo in metodo8)
            {
                Console.WriteLine("{0} {1}", gruposexo.Sexo, gruposexo.Altura);

            }
            Console.WriteLine("***");
            Console.WriteLine("9.- Los tres almumnos con menor Peso  ");

            var estadistica9 = Alumnos.OrderBy(p => p.Peso).Take(3);
                             
            foreach (var al in estadistica9)
            {
                Console.WriteLine("{0} {1} {2}", al.Nombre, al.Apellidos, al.Peso);

            }
            Console.WriteLine("***");

            Console.ReadKey();
            }
    }
}
