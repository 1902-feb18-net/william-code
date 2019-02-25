using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Delegates
{
    class MoviePlayer
    {
        public Movie CurrentMovie { get; set; }

        //this declares a delegate type.
        //all the types in c#: class, struct, inteface, enum, delegate
        //delegate type is a name for a function with a particular signature
        // (return value and parameters)
        // this one is for void-return and zero-parameters
        public delegate void MovieFinishedHandler();

        // is an event member
        // every event has a delegate type to indicate
        // what kind of functions can be subscribed to the event.
        // "there will be a MovieFinished event, and you cna subscribe to it
        // with any MovieFinishedHandler, i.e., and void-return, zero-param function."
        public event MovieFinishedHandler MovieFinished;

        // Action type is for void returning functions
        //  the type parameters are all the parameters of the function
        // Func type is for all other functions
        //  the last type parameter is for the return parameter
        public event Action<string> DiscEjected;

        // technically we can subscribe to delegate-typed members without events at all
        // but it's a bit more limited

        //return true if success, false if failure
        public bool Play()
        {
            //wait for 3 seconds
            Thread.Sleep(3000);

            // Firing the MovieFinished event
            // MovieFinished();
            // this will call not just one function, but all event subscribers.

            MovieFinished?.Invoke();
            // ?. is a special operator called the null-coalescing operator
            // if the thing to the left of it is null, it simply returns null.
            // if the thing to the left is not null, it will behave like .

            // when we fire the event, we provide all parameters that the event
            // needs
            DiscEjected?.Invoke(CurrentMovie.ToString());
            return true;
        }


    }
}
