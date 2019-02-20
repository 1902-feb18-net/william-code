using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimalsLibrary
{
    //an abstract class is like a mix of a class and interface
    //we can probide some implimentations, while leaving other things unimplemented
    class ABird : IAnimal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }

        //virtual is an extended modifier
        // meaning "opt-in derived classes being allowed to override it"
        public virtual void MakeNoise()
        {
            Console.WriteLine("Cherp!");
        }

        public void GoTo(string location)
        {
            Console.WriteLine($"Flying to {location}");
        }
    }
}
