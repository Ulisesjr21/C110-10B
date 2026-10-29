
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting("Ulises");

            Console.WriteLine(greeting.BuildMessage());
        }
    }
}
