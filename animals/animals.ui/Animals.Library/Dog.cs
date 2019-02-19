using System;


namespace animals.ui
{
    public class Dog
    {
        public string Noise = "Woof!";

        public Dog()
        {
        }

        public void GoTo(string location)
        {
            //simple way to put a string together
            Console.WriteLine("Walking to " + location);

            //string interpolation syntax
            //$ in front turns braces into "switch back to c#
           // Console.WriteLine($"Walking to {location}");
        }

        public void MakeNoise() 
        {
            Console.WriteLine(Noise);
        }
    }
}