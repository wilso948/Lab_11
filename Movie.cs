using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    public class Movie
    {
        private string _category;
        private string _title;

        public string category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string title
        {
            get { return _title; }
            set { _title = value;  }
        }
        public Movie(string Category, string Title)
        {
            category = Category;
            title = Title;
        }

        public static void GetMovie(string userInput, List<Movie> movies)
        {
            foreach (var movie in movies)

                if (userInput == (movie._category))
                {
                    Console.WriteLine(movie._title);
                }


           
        }
    }
}
