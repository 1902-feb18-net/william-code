using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsAndLINQ
{
    public static class ListExtension
    {
        
            //C# supports adding methods on to any class/struct
            //using static methods whose first parameter is declare with this
            //the class/struct which type

            public static bool Empty<T>(this List<T> list)
            {
                return list.Count == 0;
            }

            public static int Pow(this int a, int b)
            {
                if (b < 0)
                {
                    throw new ArgumentException("expontent must be nonnegative.", nameof(b));
                }
                if (b == 0) { return 1; }

                int result = a;
                while(b > 1)
                {
                    result *= a;
                    b--;
                }
            return result;
            }
        
    }
}
