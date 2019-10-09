using System;

namespace T4_ConnectionStringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(ConnectionStrings.local);
            Console.WriteLine(ConnectionStrings.development);
            Console.WriteLine(ConnectionStrings.QA);

            Console.ReadKey();
        }
    }
}
