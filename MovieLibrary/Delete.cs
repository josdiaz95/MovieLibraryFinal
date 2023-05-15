using MovieLibraryEntities.Context;


namespace MovieLibrary
{
    public class Delete
    {
        Read reading = new Read();
        public void DeleteMovie()
        {
            using (var context = new MovieContext())
            {
                if (reading.ShowMovies() != null)
                {
                    Console.WriteLine("Enter the ID of the movie to be deleted:");
                    int choice = Int32.Parse(Console.ReadLine());

                    var deleteMovie = context.Movies.FirstOrDefault(m => m.Id == choice);

                    if (deleteMovie != null)
                    {
                        context.Movies.Remove(deleteMovie);
                        Console.WriteLine("Movie successfully deleted.");
                        context.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Movie not deleted.");
                    }
                }
            }
        }


    }
}
