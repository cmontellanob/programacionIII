using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class Raya
    {
        private Char[,] tabla ;
        private int turno;
        public  Raya()
        {
            turno = 1;
            tabla = new char[3,3];
        }

        public String marcar(int x,int y, Char marca)
        {
            // verificar si el turno corresponde
            // si esta vacio marcar
            // verificar si hy ganador
            // verificar si hay empate
            // pasar el turno
            // 

        }
        private Char ganador()
        {

        }
        private Boolean empate()
        {

        }

    }
}
