using System;
using animals.Library;

namespace animals.ui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dog = new Dog();
            dog.Name = "Fido";

            dog.GoTo("door");
            dog.MakeNoise;
        }
    }
}
