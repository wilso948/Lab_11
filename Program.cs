using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again;

            do
            {
                Console.WriteLine("Welcome to The Movie List Application mmmmkay." + " (Press Any key to continue.)");
                Console.ReadKey();
                Console.WriteLine("There are 10 movies in this list mmmmkay." + " (Press Any key to continue.)");
                Console.ReadKey();
                Console.WriteLine("What category are you interested in? (Choose only: Animated, Drama, Horror, or Scifi)");
                string userInput = Console.ReadLine();

                var movies = new List<Movie>();
                movies.Add(new Movie("Drama", "Moonlight"));
                movies.Add(new Movie("Drama", "Ray"));
                movies.Add(new Movie("Horror", "Scream"));
                movies.Add(new Movie("Horror", "The Exorcist"));
                movies.Add(new Movie("Scifi", "The Martian"));
                movies.Add(new Movie("Scifi", "Interstellar"));
                movies.Add(new Movie("Scifi", "The Fifth Element"));
                movies.Add(new Movie("Animated", "The Incredibles"));
                movies.Add(new Movie("Animated", "Moana"));
                movies.Add(new Movie("Animated", "Frozen"));

                Movie.GetMovie(userInput, movies);

                Console.WriteLine("Would you like to continue?" + "(Y/N)");

                if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }

            } while (again == true);


            


        }
    }
}
