using System;

namespace Eventos
{
    public class Operaciones // Esta es la clase publicadora
    {
        public delegate void Delegado(); // lafirma del deleado debe ocnincidir con la del Manejador de eventod
        public event Delegado CuandoEvento; //evento aqui se suscriben lo manejadores de eventos 
        public int Multiplicar(int a, int b,int c)
        {
            int iMultiplicar = a * b *c;
            int iSuma = iMultiplicar/2;
            if ((iSuma % 3 == 0) && (CuandoEvento != null)) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            { CuandoEvento(); }
            return iMultiplicar;
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
                o.CuandoEvento += RecibeEvento;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos

                int res = o.Multiplicar(a,b,c);
                Console.WriteLine("La Multiplicacion  es = {0}", res);
                
            Console.ReadKey();
            }
            static void RecibeEvento() // Manejador de Evento
            {
                Console.WriteLine("Multiplo de 3");
            }
      }

    
}
