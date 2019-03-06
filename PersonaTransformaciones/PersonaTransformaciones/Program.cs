using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PersonaTransformaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> Estudiantes = new List<Estudiante>()
        {
            new Estudiante { Nombre="Svetlana",
                Apellidos="Omelchenko",
                Id=111,
                Direccion="123 Main Street",
                Ciudad="Seattle",
                Calificaciones= new List<int> { 97, 92, 81, 60 } },
            new Estudiante { Nombre="Claire",
                Apellidos="O’Donnell",
                Id=112,
                Direccion="124 Main Street",
                Ciudad="Redmond",
                Calificaciones= new List<int> { 75, 84, 91, 39 } },
            new Estudiante { Nombre="Sven",
                Apellidos="Mortensen",
                Id=113,
                Direccion="125 Main Street",
                Ciudad="Lake City",
                Calificaciones= new List<int> { 88, 94, 65, 91 } },
        };
            List<Docente> Docentes = new List<Docente>()
        {
            new Docente { Nombre="Ann", Apellidos="Beebe", Id=945, Ciudad="Seattle" },
            new Docente { Nombre="Alex", Apellidos="Robinson", Id=956, Ciudad="Redmond" },
            new Docente { Nombre="Michiyo", Apellidos="Sato", Id=972, Ciudad="Tacoma" }
        };

            // Consulta 
            var personasEnSeattle = (from e in Estudiantes
                                   where e.Ciudad == "Seattle"
                                   select e.Apellidos)
                        .Concat(from d in Docentes
                                where d.Ciudad == "Seattle"
                                select d.Apellidos);

            Console.WriteLine("Los siguientes estudiantes y docentes viven en Seattle:");
            // ejecuta la consulta
            foreach (var persona in personasEnSeattle)
            {
                Console.WriteLine(persona);
            }

            // Crea un subconjuto con un solo valor

            var consulta = from e in Estudiantes
                        select e.Ciudad;
            foreach (var persona in consulta)
            {
                Console.WriteLine(persona);
            }

            // Crea un subconjunto con dos valores
             
            var consulta1 = from e in Estudiantes
                        select new { Nombre = e.Nombre , Ciudad = e.Ciudad};
            foreach (var p in consulta)
            {
                Console.WriteLine(p);
            }

            // transforma en XML 
            var EstudiantesToXML = new XElement("Root",
            from e in Estudiantes
            let scores = string.Join(",", e.Calificaciones)
            select new XElement("estudiante",
                       new XElement("Nombre", e.Nombre),
                       new XElement("Apellidos", e.Apellidos),
                       new XElement("Calificaciones", scores)
                    ) // end "estudiante"
                ); // end "Root"

            // Execute the query.
            Console.WriteLine(EstudiantesToXML);

            // Crea un subconjunto con dos valorescalculados del conjunto

            var consulta2= from e in Estudiantes
                            select new { NombreCompleto = e.Nombre+" "+e.Apellidos};

            Console.WriteLine("Presione Cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
