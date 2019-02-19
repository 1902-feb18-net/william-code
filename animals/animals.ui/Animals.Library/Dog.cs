using System;


namespace animals.ui
{
    public class Dog
    {
        internal string Noise = "Woof!";

        public string getNoise()
        {
            return Noise;
        }

        public void setNoise(string newValue)
        {
            if (newValue == null || newValue.Length == 0)
            {
                throw new ArgumentException("value must not be null or 0");
            }
            Noise = newValue;
        }

        private string _name;
        public string Name {
            get
            {
                return _name;
            } 
            set
            {
                _name = value;
            }
            }
        // property syntax provides getters and setters
        // pretending to be fields
        // in C# we have properties where other languages would just
        // use fields on there own
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