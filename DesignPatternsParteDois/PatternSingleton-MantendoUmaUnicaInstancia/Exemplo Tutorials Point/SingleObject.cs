using System;

namespace PatternSingleton_MantendoUmaUnicaInstancia
{
    public class SingleObject
    {
        private static SingleObject instance = new SingleObject();

        private SingleObject() { }

        public static SingleObject getInstance()
        {
            return instance;
        }

        public void showMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}