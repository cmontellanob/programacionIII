using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultaDocentes
{
    class Alumnos
    {
        static void Main(string[] args)
        {
                Docente[] Docentes = new Docente[4];
                List <Alumno>Alumnos1= new List<Alumno>();
                Alumnos1.Add(new Alumno("Dionicio"));
                Alumnos1.Add(new Alumno("Pedro"));
                Alumnos1.Add(new Alumno("Juan"));
                Docentes[0] = new Docente("Juan", "Perez",  "Masculino", 35, "Ing. Industrial",Alumnos1);
                List<Alumno> Alumnos2 = new List<Alumno>();

                Alumnos2.Add(new Alumno("Marcela"));
                Alumnos2.Add(new Alumno("Ricardo"));
                Alumnos2.Add(new Alumno("Maria"));

                Docentes[1] = new Docente("Maria", "Gomez", "Femenino", 33, "Ing. Civil", Alumnos2);

            List<Alumno> Alumnos3 = new List<Alumno>();

            Alumnos3.Add(new Alumno("Marcela"));

            Docentes[2] = new Docente("Pedro", "Vaca", "Masculino", 35, "Ing. Civil", Alumnos3);

            List<Alumno> Alumnos4 = new List<Alumno>();

            Alumnos4.Add(new Alumno("Dionicio"));
            Alumnos4.Add(new Alumno("Pedro"));
            Alumnos4.Add(new Alumno("Juan"));

            Docentes[3] = new Docente("Martha", "Aramyo", "Femenino", 40, "Ing. Industrial", Alumnos4);

            //a Sintaxis de Consulta
            Console.WriteLine("1.- lista docentes odenada por edad y luego por nombre");
                var consulta1 = from d in Docentes
                                orderby d.Edad ,d.Nombre
                                select d; 
                                 

                foreach (Docente p in consulta1)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("***");

                Console.WriteLine("2.- lista de los docente cuya edad es 35");

                var consulta2 = from doc in Docentes
                                where doc.Edad == 35
                                select doc;
                foreach (Docente p in consulta2)
                {
                    Console.WriteLine(p);
                }

                Console.WriteLine("3.- Cantidad de Docente Agrupadas por Carrera y Sexo");

            //
            var consulta3 = from doc in Docentes
                            group doc by new { doc.Carrera, doc.Sexo} into CarreraSexo
                            select new { Carrera = CarreraSexo.Key.Carrera,Sexo=CarreraSexo.Key.Sexo ,Cantidad = CarreraSexo.Count() };
            foreach (var grupocarrera in consulta3)
            {
                Console.WriteLine("{0} {1} {2}", grupocarrera.Carrera, grupocarrera.Sexo, grupocarrera.Cantidad);

            }


            Console.WriteLine("4.- Cantidad de Docentes del Sexo Femenino agrupado por Edad");

            //
            var consulta4 = from doc in Docentes
                            where doc.Sexo=="Femenino"
                            group doc by doc.Edad into edad
                            select new { Edad = edad.Key, Cantidad = edad.Count() };
            foreach (var gruposexo in consulta4)
            {
                Console.WriteLine("{0} {1}", gruposexo.Edad, gruposexo.Cantidad);

            }
              Console.ReadKey();

            }


        }
    }


