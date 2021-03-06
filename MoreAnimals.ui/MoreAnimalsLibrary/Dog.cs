﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimalsLibrary
{
    //Dog implements IAnimal interface
    //which means every member specified by IAnimal is guaranteed to be present on this class
    public class Dog : IAnimal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("woof!");
        }

        public void GoTo(string location)
        {
            Console.WriteLine($"Walking to {location}");
        }
    }
}
