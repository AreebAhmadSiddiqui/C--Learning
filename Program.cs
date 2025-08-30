using System;

namespace OopsProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Events obj1 = new Events();
            string result = obj1.RaiseEvent("Areeb");
            Console.WriteLine(result);
        }
    }
}