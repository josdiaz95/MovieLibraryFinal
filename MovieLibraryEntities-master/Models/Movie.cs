using System.Text;

namespace MovieLibraryEntities.Models
{
    public class Movie
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual ICollection<UserMovie> UserMovies { get; set; }

        public string PrintMovieGenres()
        {
            if (MovieGenres != null || !MovieGenres.Any())
            {
                var sb = new StringBuilder();
                foreach (var genres in MovieGenres)
                {
                    string genreName = genres.Genre.Name;
                    sb.Append(genreName);
                }

                return sb.ToString();
            }
            return "";
        }
    }
}
