using System;
using System.Collections.Generic;
using System.Text;

namespace Colas
{
    //class Alumno
    //{
    //    String Nombre;
    //    public Alumno(string dato)
    //    {
    //        Nombre = dato;
    //    }
    //}

    class Docente
    {
        String nombre { set; get; }
        int edad { set; get; }
        String sexo { set; get; }
        //int Edad;
        String carrera { set; get; }
        // List<Alumno> ListaAlumnos;
        public Docente (string pnombre,int pedad, string psexo,string pcarrera)
        {
            nombre = pnombre;
            edad = pedad;
            sexo = psexo;
            carrera = pcarrera;
        }
        override public string ToString()
        {
            return nombre + " " + edad.ToString() + " " + sexo + " " + carrera;
        }

    }
}
