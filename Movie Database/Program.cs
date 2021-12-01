using System;
using System.Linq;
using System.Collections.Generic;

namespace Movie_Database
{
    class Movie
    {
        public string Title;
        public string Category;
        public int Runtime;
        public int ReleaseYear;

        public Movie(string title, string category, int runtime, int releaseYear)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            ReleaseYear = releaseYear;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"{Title,-32} {Runtime,-12} {ReleaseYear,-12}");
        }

        public bool MovieHasCategory(string category)
        {
            return (category == Category);
        }
    }
    class Program
    {
        static void PrintCategories(List<string> categories)
        {
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i]}");
            }
        }
        static void Main(string[] args)
        {
            List<string> categoryList = new List<string>() { "Comedy", "Horror", "Action", "Fantasy" };

            List<Movie> movies = new List<Movie>()
            {
                new Movie("Free Guy", "Comedy", 115, 2021),
                new Movie("Holidate", "Comedy", 104, 2020),
                new Movie("Malignant", "Horror", 111, 2021),
                new Movie("Don't Breathe 2", "Horror", 98, 2021),
                new Movie("The Deep House", "Horror", 85, 2021),
                new Movie("Red Notice", "Action", 115, 2021),
                new Movie("No Time To Die", "Action", 163, 2021),
                new Movie("Raya and the Last Dragon", "Fantasy", 114, 2021),
                new Movie("Luca", "Fantasy", 95, 2021),
                new Movie("Mulan", "Fantasy", 115, 2020)
            };

            movies.Sort((comparing, comparer) => comparing.Title.CompareTo(comparer.Title));

            bool run = true;

            do
            {
                Console.WriteLine("Here's a list of categories:\n");

                PrintCategories(categoryList);

                Console.Write("\nPlease pick a category: ");

                string input = "";
                int categoryNum = 0;

                bool validInput = false;
                do
                {
                    input = Console.ReadLine();
                    if (int.TryParse(input, out categoryNum) && categoryNum >= 1 && categoryNum <= 4)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid category: ");
                    }
                } while (!validInput);

                string category = categoryList[categoryNum - 1];

                Console.WriteLine($"\nHere's a list of {category} movies.\n");

                Console.WriteLine($"{"Title",-32} {"Runtime",-12} {"Release Year",-12}");

                List<Movie> sortedMovies = movies.OrderBy(movie => movie.Title).ToList();

                foreach (Movie movie in movies)
                {
                    if (movie.MovieHasCategory(category))
                    {
                        movie.PrintMovie();
                    }
                }

                Console.Write("\nWould you like to pick another category? (y/n) ");

                validInput = false;
                do
                {
                    input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        validInput = true;
                    }
                    else if (input == "n")
                    {
                        validInput = true;
                        run = false;
                    }
                    else
                    {
                        Console.Write("Please enter (y/n) ");
                    }
                } while (!validInput);

                Console.WriteLine("");

            } while (run);
        }
    }
}
