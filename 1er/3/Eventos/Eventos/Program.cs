using System;

namespace Eventos
{
    public class Operaciones // Esta es la clase publicadora
    {
        public delegate void Delegado(); // lafirma del deleado debe ocnincidir con la del Manejador de eventod
        public event Delegado CuandoDiscirminanteMenor0; //evento aqui se suscriben lo manejadores de eventos 
        public void Raices(int a, int b,int c)
        {
            Double iDiscriminante = (b*b-4*a*c);
            if (iDiscriminante > 0 ) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            {
                Double x1 = (-b + Math.Sqrt(iDiscriminante))/2*a;
                Double x2 = (-b - Math.Sqrt(iDiscriminante))/2*a;
                Console.WriteLine("x1= {0}",x1);
                Console.WriteLine("x1= {0}", x2);
            }
            else
            {
                if (CuandoDiscirminanteMenor0 != null)
                {
                    CuandoDiscirminanteMenor0();
                }
            }

        }
    }
    class ProgramaEvento
    {
            static void Main()
            {
            Console.WriteLine("Introduzca a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca c");
            int c = int.Parse(Console.ReadLine());

            Operaciones o = new Operaciones();
            o.CuandoDiscirminanteMenor0+= RecibeImaginario;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos
            o.Raices(a,b,c);
            Console.ReadKey();
            }
            static void RecibeImaginario() // Manejador de Evento
            {
                Console.WriteLine("raiz imaginaria");
            }
      }

    
}
