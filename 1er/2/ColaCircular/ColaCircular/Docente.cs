using System;
using System.Collections.Generic;
using System.Text;

namespace ColaCircular
{
    class Docente
    {
           String nombre { set; get; }
            int edad { set; get; }
            String sexo { set; get; }
            String carrera { set; get; }
            public Docente(string pnombre, int pedad, string psexo, string pcarrera)
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



