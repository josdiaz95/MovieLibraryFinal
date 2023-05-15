using System.Runtime.CompilerServices;
using MovieLibraryEntities.Context;
using MovieLibraryEntities.Models;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MovieUI
{
    public partial class SearchMoviesForm : Form
    {

        public string keyWord;

        public SearchMoviesForm(string value)
        {
            InitializeComponent();
            keyWord = value;
            for (int i = 0; i <= foundMovieListView.Items.Count - 1; i = (i + 2))
            {
                foundMovieListView.Items[i].BackColor = Color.Gainsboro;
            }
        }


        public int Read()
        {
            // foundMovieListView.Items.Clear();

            using (var context = new MovieContext())
            {
                var movieList = context.Movies.ToList();

                var foundMovies = movieList.Where(m =>
                   m.Title.Contains(keyWord, StringComparison.InvariantCultureIgnoreCase)).ToList();

                string[] arr = new string[3];


                foundMovieListView.Columns.Add("ID", 100);
                foundMovieListView.Columns.Add("Title", 1200);
                foundMovieListView.Columns.Add("Genres", 450);
                foundMovieListView.GridLines = true;
                ListViewItem item;


                if (foundMovies.Any())
                {
                    var movieResults = context.Movies
                        .Include(x => x.MovieGenres)
                        .ThenInclude(x => x.Genre)
                        .Where(x => x.Title.ToLower().Contains(keyWord));

                    foreach (var movie in movieResults)
                    {
                        long id = movie.Id;
                        string title = movie.Title;
                        string genres = movie.PrintMovieGenres();

                        arr[2] = genres;
                        arr[0] = id.ToString();
                        arr[1] = title;
                        item = new ListViewItem(arr);
                        foundMovieListView.Items.Add(item);
                    }
                }
            }

            return foundMovieListView.Items.Count;
        }

    }

}

