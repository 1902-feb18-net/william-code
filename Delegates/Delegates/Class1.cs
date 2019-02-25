using System;

namespace Delegates
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            var moviePlayer = new MoviePlayer
            {
                CurrentMovie = Movie.StarWars4
            };

            MoviePlayer.MovieFinishedHandler handler = EjectDisc;

            // subscribe to an event
            moviePlayer.MovieFinished += handler;

            // unsubscribe to an event
            // moviePlayer.MovieFinished -= handler;

            moviePlayer.MovieFinished += () =>
            {
                Console.WriteLine("handle event with block-body lambda.");
            };

            moviePlayer.MovieFinished += () => Console.WriteLine("Expression body");

            //we can specify type on lambda funtion parameters
            // but usually they are inferred from context (like var does)

            moviePlayer.DiscEjected += s => Console.WriteLine($"Ejecting {s}");

            FuncAndAction();

            Console.WriteLine("Playing movie...");

            moviePlayer.Play();

            // wait for me to press enter before exiting
            Console.ReadLine();


        }

        private static void FuncAndAction()
        {
            Func<string, string, int> func = (s1, s2) => s1.Length + s2.Length;
            Action<string, string, int> action = (s1, s2, i) => Console.WriteLine(s1 + s2 + i);
        }

        public static void EjectDisc()
        {
            Console.WriteLine("We are ejecting the disc");
        }
    }
}
