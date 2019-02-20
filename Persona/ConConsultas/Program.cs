using System;
using System.Collections.Generic;
using System.Linq;

namespace ConConsultas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] Alumnos = new Persona[7];
            Alumnos[0] = new Persona("Diego", "La Torre", 18, "Masculino", "13121920", 1.74, 76);
            Alumnos[1] = new Persona("Diego", "Castro", 19, "Masculino", "7483306", 1.69, 70);
            Alumnos[2] = new Persona("Isabel", "Lopez", 19, "Femenino", "7504259", 1.65, 60);
            Alumnos[3] = new Persona("Rossimar", "Guzman", 18, "Femenino", "5713604", 1.54, 40);
            Alumnos[4] = new Persona("Franco", "Adamczyk", 18, "Masculino", "12609597", 1.74, 77);
            Alumnos[5] = new Persona("Gustavo", "Zarate", 19, "Masculino", "12575699", 1.76, 60);
            Alumnos[6] = new Persona("Dieter", "Quiñones", 19, "Masculino", "7547264", 1.67, 57);

            //Sintaxis de Consulta
            Console.WriteLine("1.- lista detodos los alumnos");
            var consulta1 = from alm in Alumnos
                            select alm;
            
            foreach (Persona p in consulta1)
            {
                Console.WriteLine("{0} {1} {2} {3} ",p.Nombre, p.Apellidos,p.Edad,p.Sexo);
            }
            Console.WriteLine("***");

            Console.WriteLine("2.- lista de los alumnos cuya edad sea mayora 18");

            var consulta2 = from alm in Alumnos
                            where alm.Edad > 18
                            select alm;
            foreach (Persona p in consulta2)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }

            Console.WriteLine("***");

            Console.WriteLine("3.- lista de alumnos ordenada por apellidos");
            // 
            var consulta3 = from alm in Alumnos
                            orderby alm.Apellidos
                            select new { alm.Nombre, alm.Apellidos };
            foreach (var p in consulta3)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }

            Console.WriteLine("***");

            Console.WriteLine("4.- lista de alumnos ordenada por nombre luego por apellido descendentemente");
            //
            var consulta4 = from alm in Alumnos
                            orderby alm.Nombre, alm.Apellidos descending
                            select alm;
            foreach (var p in consulta4)
            {
                Console.WriteLine("{0}, {1}", p.Nombre, p.Apellidos);
            }

            Console.WriteLine("***");

            Console.WriteLine("5.- Lista de Alumnos Agrupadas por Edades ");

            //
            var consulta5 = from almu in Alumnos
                            group almu by almu.Edad into edad
                            select edad;
            // Grupo Edades
            foreach (var GrupoEdades in consulta5)
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

            var consulta6 = from almu in Alumnos
                            group almu by almu.Edad into edad
                            select new { Edad = edad.Key, Cantidad = edad.Count() };
            foreach (var grupoedad in consulta6)
            {
                Console.WriteLine("{0} {1}", grupoedad.Edad, grupoedad.Cantidad);

            }
            Console.WriteLine("***");
            //
            Console.WriteLine("7.- Promedio de Edad por Sexo ");

            var consulta7 = from almu in Alumnos
                            group almu by almu.Sexo into sexos
                            select new { Sexo = sexos.Key, Promedio = sexos.Average(pe => pe.Edad) };
            foreach (var grupoedad in consulta7)
            {
                Console.WriteLine("{0} {1}", grupoedad.Sexo, grupoedad.Promedio);

            }
            Console.WriteLine("***");
            Console.WriteLine("8.- Las personas mas alta por sexo  ");

            var consulta8 = from almu in Alumnos
                            group almu by almu.Sexo into Alturas 
                            select new { Sexo=Alturas.Key,Altura= Alturas.Max(p => p.Altura) };
            foreach (var gruposexo in consulta8)
            {
                Console.WriteLine("{0} {1}", gruposexo.Sexo, gruposexo.Altura);

            }
            Console.WriteLine("***");
            Console.WriteLine("9.- Los tres almumnos con menor Peso  ");

            var consulta9 = (from almu in Alumnos
                            orderby almu.Peso 
                            select  almu).Take(3);
            foreach (var al in consulta9)
            {
                Console.WriteLine("{0} {1} {2}", al.Nombre,al.Apellidos,al.Peso);

            }
            Console.WriteLine("***");

            Console.ReadKey();

            }
        
    }
}
