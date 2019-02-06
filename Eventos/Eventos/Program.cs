using System;

namespace Eventos
{
    public delegate string MiDelegado(string str);

    class ProgramaEvento
    {
        event MiDelegado MiEvento;

        public ProgramaEvento()
        {
            this.MiEvento += this.Bienvenida;
        }

        public string Bienvenida(string usuario)
        {
            return "Bienvenido " + usuario;
        }

        static void Main(string[] args)
        {
            ProgramaEvento objeto = new ProgramaEvento();
            string result = objeto.MiEvento("Carlos");
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
