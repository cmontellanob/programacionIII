using System;

namespace Eventos
{
    public class Operaciones // Esta es la clase publicadora
    {
        public delegate void Delegado(); // lafirma del deleado debe ocnincidir con la del Manejador de eventod
        public event Delegado CuandoSumaMultiplosCinco; //evento aqui se suscriben lo manejadores de eventos 
        public int Promedio(int a, int b,int c)
        {
            int iPromedio = (a + b +c)/3;
            int iSuma = a + b + c;
            if ((iSuma % 5 == 0) && (CuandoSumaMultiplosCinco != null)) // cuando ocurre el evento de sermultiplo de 5 tenemos que llamar a evento para dispare enlos suscriptores
            { CuandoSumaMultiplosCinco(); }
            return iPromedio;
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
                o.CuandoSumaMultiplosCinco+= RecibeSumaMultiploCinco;// nos estamos suscribiendo a eventoy mandandoalmanejador de eventos

                int res = o.Promedio(a,b,c);
                Console.WriteLine("EL Promedio  es = {0}", res);
                
            Console.ReadKey();
            }
            static void RecibeSumaMultiploCinco () // Manejador de Evento
            {
                Console.WriteLine("Multiplo de cinco ");
            }
      }

    
}
