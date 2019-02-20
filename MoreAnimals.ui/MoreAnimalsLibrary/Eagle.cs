using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimalsLibrary
{
   public class Eagle : ABird
    {
        
        public override void MakeNoise()
        {
            Console.WriteLine("Caw!");
        }

        public override void GoTo(string location)
        {
            Console.WriteLine($"I'm an eagle, Flying to {location}");
        }
    }
}
