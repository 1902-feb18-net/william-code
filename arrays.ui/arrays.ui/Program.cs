using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays.ui
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays
            //lists
            //sets
            //string equality

            //other collections
            new Stack<int>(); //last-in, first-out
            new Queue<int>(); //first-in, first-out

            static void Maps()
            {
                var dictionary = new Dictionary<string, string>();
                dictionary["classroom"] = "room where classes are held";

                var grades = new Dictionary<string, double>();
                
                    //we also have an initializer syntax for dicitonaries
                    grades["Nick"] = 80;
                //helpful members: keys, values, containskey, containsvalue, trygetvalue

                foreach (KeyValuePair<string, double> item in grades)
                {
                    //item.key;
                    //item.value;
                }

                //dictionary objects let you use any type you want ot index into it
                // and any type to use for the value stored for that key
                
            }

            static void StringEquality()
            {
                string a = "asdf";
                string b = "asdf";
                Console.WriteLine(a == b); //returns true

                //value types and reference types
                //value type variables store their values directly
                //reference type variables store a reference to their value

                //in c# may of our basic types are value types:
                //int, double, bool, float, long

                int n1 = 5;
                int n2 = n1;

                var dummy1 = new Dummy();
                var dummy2 = dummy1;

                dummy1.Data = 10;
                if (dummy2.Data == 10)
                {
                    Console.WriteLine("reference type");
                }
                else
                {
                    Console.WriteLine("value type");
                }
                //structs are copied entirely every time we pass it to a new method
                //or assign it to a new variable
                //value types are deleted from memory as soon as the one variable that contains them passes out of scope

                //reference types need to be garbage collected because we dont know right away
                //when the last variable pointing to it has passed out of scope

                //Dummy is a reference type, so dummy 2 is a copy of the reference
                //i.e. a new reference to the same object

                //objects made from classes are reference types, always
                //objects made from structs are value types
                //all the built-in value types are "structs" in C#

                //in C#, all value types do derive ultimately from object
                //so we can always upcast them to object variables

                int i1 = 5;
                object o2 = i1; //imlicit upcasting
                //this is called "boxing" - the int is wrapped inside a reference type
                //to give that value reference type semantics

                //java has awkward Integer vs int distinctions
                // we have this as boxing and unboxing with object
                // "unboxing" ... the reverse with downcasting
                int i2 = (int)o2; // extract that value from inside the object wrapper

            }
        }
        public class Dummy { public int Data { get; set; } }

        public struct ValueDummy { int Data { get; set; } }
    }
}
