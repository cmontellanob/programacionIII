using System;

namespace SingletonPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleObject ob = SingleObject.getInstance();
            ob.setValor("Objeto 1");
            ob.ShowMethod();
            SingleObject ob2 = SingleObject.getInstance();
            ob2.ShowMethod();
            SingleObject ob3 = SingleObject.getInstance();
            ob2.ShowMethod();



            Console.ReadLine();
        }
    }
}
