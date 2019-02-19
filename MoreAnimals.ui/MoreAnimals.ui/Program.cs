using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MoreAnimalsLibrary;

namespace MoreAnimals.ui
{
    class Program
    {
        static void Main(string[] args)
        {
            var fido1 = new Dog();
            fido1.AnimalId = 1;
            fido1.Name = "Fido";
            fido1.Breed = "Doberman";

            var fido2 = new Dog();
            fido2.AnimalId = 2;
            fido2.Name = "Fido";
            fido2.Breed = "Doberman";

            //we use camelCase for local variables and private fields
            // TitleCase aka PascalCase for everything else

            IAnimal animal = fido1;
            //converting from dog variable to Ianimal variable is "upcasting"
            //converting from IAnimal to dog is "downcasting" 
            //not guaranteed to succeed so it must be explicit with casting

            

        }
    }
}
