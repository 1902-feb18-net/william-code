using System;
using System.Collections.Generic;

namespace CollectionTesting.Library
{
    class MyStringCollection : MyGenericCollection<string>
    {
        // use a private or protected field
        //to store a list<string> to handle all the list operations

        //implement some collection methods like add, contains, remove, and some
        //others that are not already on the list

        //at least 5 methods

        public MyStringCollection() : base()
        {

        }

        public MyStringCollection(string[] initial) : base(initial)
        {

        }

        private readonly List<string> _string = new List<string>();

        public void Add(string value)
        {
            _string.Add(value);
        }

        public bool Contains(string value )
        {
            return _string.Contains(value);
        }

        public void Remove(string value)
        {
            _string.Remove(value);
        }

        /// <summary>
        /// Replace all contained strings with lowercased versions.
        /// </summary>
        public void MakeLowercase()
        {
            for (int ii = 0; ii < _string.Count; ii++)
            {
                _string[ii] = _string[ii].ToLower();
            }
        }

        public void RemoveEmpty()
        {
            while(_string.Contains(""))
            {
                _string.Remove("");
            }
            // or..
            // using lambdas
            // _string.RemoveAll(x => x == "");
        }


    }
}
