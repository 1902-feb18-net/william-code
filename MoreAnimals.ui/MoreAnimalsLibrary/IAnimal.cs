using System;
using System.Collections.Generic;
using System.Text;

namespace MoreAnimalsLibrary
{
    public interface IAnimal
    {
        //in an interface, the members must have the same access level
        //as the whole interface, so, we do not say it explicitly

        int AnimalId { get; set; }
        string Name { get; set; }
        void MakeNoise();
        void GoTo(string location);
    }
}
