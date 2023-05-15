using MovieLibraryEntities.Context;

namespace MovieLibrary;

public class Read
{
    public string ShowMovies()
    {
        string result = null;

        using (var context = new MovieContext())
        {
            Console.WriteLine("Enter a keyword/title to search for a movie");
            string movieSearch = Console.ReadLine().ToUpper();

            Console.WriteLine($"\nSearching with ({movieSearch.ToUpper()})");

            var movieList = context.Movies.ToList();

            var foundMovies = movieList.Where(m =>
                m.Title.Contains(movieSearch, StringComparison.InvariantCultureIgnoreCase));

            if (foundMovies.Any())
            {
                Console.WriteLine($"\nMovies found:\n");
                foreach (var m in foundMovies)
                {
                    result = ($"\n{m.Id}) {m.Title} \nGenres:");
                    Console.WriteLine(result);
                    foreach (var genre in m.MovieGenres)
                    {
                        System.Console.WriteLine($"\t{genre.Genre.Name}");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNo movies found.");
            }

            Console.WriteLine();

            return result;
        }
    }
}

