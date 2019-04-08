using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// Simple escenario de hilos :  comenzar un metodoestatico en segundo plano

namespace Threading
{


public class ThreadExample
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Procedimiento Hilo: {0}", i);
              Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Hilo Principal : Comienza el segundo hilo.");
            Thread t = new Thread(new ThreadStart(ThreadProc));

            t.Start();

            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("Hilo Principal haciendo algun trabajo");
                Thread.Sleep(500);
            }

            Console.WriteLine("Hilo Principal: llamadaa Join(), para esperar que el ThreadProc Termine.");
            t.Join();
            Console.WriteLine("Hilo Principal: ThreadProc.Join ha devuelto.  fin del programa.");
            Console.ReadLine();
        }
    }
}

