using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number: ");
                var input = Console.ReadLine();

            //try
            //{
            //    var number = int.Parse(input);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input.");
            //    throw;
            //}

            // Console.WriteLine($"Number Entered: {number}");

            //out-parameters are declared outside the method call,
            // and then the method fills in the value
            //(it's normally not possible for a method to directly change a 
            //variable outside of it)

            //This enables methods to effectively, return several things at once

            int number;
            if (int.TryParse(input, out number))
            {
                Console.WriteLine($"Number entered: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            //we can also just declare the out parameter in the call
            int.TryParse(input, out var num);

            var dict = new Dictionary<string, int>();
            if (dict.TryGetValue("nick", out var value))
            {
                //work with value
            }

            int x = 40;
            ChangeMyInt(ref x);
            Console.WriteLine(x);

            //ref parameters let us pass a whole variable to a function
            // and have it chage the contents of that variable freely

            //ref has a greater performance penalty than out

            //we also have pointers in C#
            unsafe
            {
                //declare int
                int x2 = 20;
                
                //get the memory address of that int as a pointer to the int
                int* pointer = &x2;
                Console.WriteLine((int)pointer);

                // pass it to a function to change the value at that address
                ChangeMyIntTwo(pointer);
            }

            // we need unsafe code sometimes, when we are
            // calling unmanaged APIs (like Windows API) that requires pointers
            // as arguments to their methods, otherwise avoid it.

            ILogger logger = LogManager.GetCurrentClassLogger();

            logger.Debug("Logger created successfully");

            try
            {
                int.Parse("abc");
            }
            catch (Exception ex)
            {

                logger.Error(ex);
            }

            var logline = "2019-02-22 10:37:42.0896 DEBUG Logger created successfully";
            var match = Regex.Match(logline, @"([\d-]+) ([\d:.]+) (\w+)");
            // regex syntax:
            // "character classes": \d for digits, \w for word characters (letters,numbers,and underscore)
            // \s for whitespace, most of these have a "opposite" version with uppercase
            // \S for all non-whitespace

            // [abcd] means, one character Either a, b, c, or d.

            //* means 0 to many
            //+ means 1 to many

            //() are for surrounding groups of characters that you want
            // to extract later


            //third capturing group
            string logLevel = match.Groups[3].Value;
            string dateStr = match.Groups[1] + " " + match.Groups[2];
            if(DateTime.TryParse(dateStr, out var date))
            {
                Console.WriteLine(date);
            }
            else
            {
                Console.WriteLine($"couldn't parse date {dateStr}");
            }
            Console.WriteLine(logLevel);

            Console.ReadLine();

            
        }
        public static void ChangeMyIntDoesntWork(int number)
        {
            number = 10;
        }

        public static void ChangeMyInt(ref int number)
        {
            number = 10;
        }

        //to compile unsafe code we need to enable it on a 
        // project level(csproj file)
        public static unsafe void ChangeMyIntTwo(int* number)
        {
            //pointers are like ref variables
            // but less abstraced, we can see the exact
            // memory location of the value
            *number = 5;
        }
    }
}
