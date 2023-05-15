using MovieLibraryEntities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class Update
    {
        Read reading = new Read();
        public void UpdateMovie()
        {
            using (var context = new MovieContext())
            {

                if (reading.ShowMovies() != null)
                {
                    Console.WriteLine("Enter the ID of the movie to be update:");
                    int choice = Int32.Parse(Console.ReadLine());

                    var updateMovie = context.Movies.FirstOrDefault(m => m.Id == choice);

                    if (updateMovie != null)
                    {
                        Console.Write("New movie title: ");
                        var updatedTitle = FirstLetterCap(Console.ReadLine());

                        Console.Write("New release date:MM-DD-YYYY\n ");
                        var updatedReleaseDate = System.Console.ReadLine();
                        
                        updateMovie.Title = updatedTitle + " " + $"({updateMovie.ReleaseDate.Year})";
                        updateMovie.ReleaseDate = Convert.ToDateTime(updatedReleaseDate);

                        context.Movies.Update(updateMovie);
                        context.SaveChanges();
                        Console.WriteLine("Movie Updated!");
                    }
                }
                else
                {
                    Console.WriteLine("\nMovie can't be updated.");
                }
            }
        }

        static string FirstLetterCap(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }
    }
}
