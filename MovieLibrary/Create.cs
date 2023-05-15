using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using MovieLibraryEntities.Context;
using MovieLibraryEntities.Models;

namespace MovieLibrary
{
    public class Create
    {
        public void CreateMovie()
        {
            using (var context = new MovieContext())
            {
                var movie = new Movie();

                Console.Write("Add movie title: ");
                var createTitle = FirstLetterCap(Console.ReadLine());
                movie.Title = createTitle;
                Console.Write("Add release date:MM-DD-YYYY\n");
                var movieReleaseDate = System.Console.ReadLine();
                movie.ReleaseDate = DateTime.Parse(movieReleaseDate);

                context.Add(movie);
                context.SaveChanges();
                Console.WriteLine($"Movie created: Title {movie.Title})"
                );
            }
           
        }
        static string FirstLetterCap(string str1)
            {
                return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
            }

    }
}
