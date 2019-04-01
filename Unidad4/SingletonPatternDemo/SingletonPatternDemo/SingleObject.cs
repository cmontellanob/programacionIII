using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternDemo
{
    class SingleObject
    {
        private String valor = "";
        private static SingleObject instance;
        private SingleObject()
        {
            
        }
        public void setValor(String v)
        {
            valor = v;
        }
        public static SingleObject getInstance()
        {
            if (instance == null)
                instance= new SingleObject();
            
                return instance;
        }   
        public void ShowMethod()
        {
            Console.WriteLine("soy singleton con valor {0}",valor);
        }
    }
}
