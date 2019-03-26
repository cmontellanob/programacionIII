using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultaDocentes
{
    class Alumno
    {
        String Nombre;
        public Alumno(string dato)
        {
            Nombre = dato;
        }
    }
  
    class Docente
    {
        public String Nombre { set; get; }
        public String Apellidos { set; get; }
        public String Sexo { set; get; }
        public int Edad { set; get; }
        public String Carrera { set; get; }
        List<Alumno> ListaAlumnos;
        public Docente(string pnombre, string papellidos, string psexo, int pedad, string pcarrera,List<Alumno> plista)
        {
            Nombre = pnombre;
            Apellidos = papellidos;
            Sexo = psexo;
            Edad = pedad;
            Carrera = pcarrera;
            ListaAlumnos = plista;
        }
        override public string ToString()
        {
            return Nombre + " " +Apellidos+" "+  Sexo + " " + Edad.ToString() + " " + Carrera;
        }

    }
}
