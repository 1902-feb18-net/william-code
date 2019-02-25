using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsAndLINQ
{
    class Program
    {
        static void Main()
        {
            int result = 3.Pow(3);
            List<string> list = new List<string>();
            list.Empty();

            //extension methods don't allow us to truly modify the original type
            //they are only visible when we have a using directive
            // for the namespace where my static method is defined

            //extension methods don't let us see any private/protected members
            //we can't cheat the access modifiers

            //LINQ
            //language-integrated Query
            //linq is a bunch of extension methods on IEnumerable<T> and IQueryable<T>
            //all come from Syste.Linq namespace
            list.ToList();

            list.AddRange(new string[] { "a", "b", "b", "asdfasdfasdfasdf" });

            int sum = 0;
            foreach (var s in list)
            {
                sum += s.Length;
            }
            double averageStringLength = sum / list.Count;

            Console.WriteLine(averageStringLength);

            //with linq...
            averageStringLength = list.Average(s => s.Length);

            Console.WriteLine(averageStringLength);

            //a "lambda" is akind of like a method thats anonymous
            //and can be treated like an ordinary value/object
            Func<string, int> numberOfAs = x => x.Count(c => c == 'a');
            var numOfAllAs = list.Sum(numberOfAs);
            var numOfAllBs = list.Sum(NumberOfBs);


            //functional programming is a paradigm like
            //oop, like procedural programming

            //we treat functions/methods as if they were just another piece of data

            //C# is not a purely functional language
            //but it does have lenty of support for programming in that style
            //especially with linq

            //linq has two syntax..
            //method syntax
            //and query syntax (sql wannabe)

            //var allEmptyStrings = from x in list
            //                      where x == ""
            //                      select x;
            //method syntax way
            // var allEmptyStrings = list.Where(x => x = "");

            //linq methods we should know

            // Any
            bool anyStringsLongerThanFive = list.Any(s => s.Length > 5);

            // All
            bool allStringsLongerThanFive = list.All(s => s.Length > 5);

            //we have contains(value)
            //we have count(), Count(filterFunction)
            //DefaultIfEmpty
            //Distinct
            //orderby "sorts list by condition"

            //the second characters of all the unique strings that start with 'a'
            var asdf = list.Distinct().Where(x => x[0] == 'a').Select(x => x[1]);
            //select and where are the most common ones
            //select applies a mapping to the collection
            //where filters a collection on some condition

            IEnumerable<string> allWithLengthThree = list.Where(s => s.Length == 3);
            //defered execution
            //many of these linq methods return ienumerable, never
            //whaterver the original collection type was. in such cases,
            //the processing defined by the method calls doesn't happen
            //until to start trying to pull values out of that ienumerable
            foreach(var item in asdf)
            {
                // Here in this loop, we are actually executing the logic from line 86
                Console.WriteLine("this prints before the exception");
            }
            //when we dont want deffered execution, we want all the values right now...
            //we often use .ToList()

            asdf.Last();
            asdf.Last();
            asdf.Last();
            asdf.Last();
            //we sometimes want to avoid running the operations repetitively

            //apart from being used for linq, the importace of IEnumerable is
            //that it alllws iterating with foreach statement
        }
        static int NumberOfBs(string x)
        {
            var count = 0;
            for(int i=0; i < x.Length; i++)
            {
                if (x[i] == 'b')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
