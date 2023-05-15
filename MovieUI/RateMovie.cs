
using System.ComponentModel;
using MovieLibraryEntities.Context;
using MovieLibraryEntities.Models;


namespace MovieUI
{
    public partial class RateMovie : Form
    {
        public RateMovie()
        {
            InitializeComponent();
        }


        private void RateMovie_Load(object sender, EventArgs e)
        {
            DisplayUserId();
            DisplayMovies();
            RateLevel();
            ListView();
        }
        private void rateButton_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<ComboBox>().Any(t => t.SelectedItem == null))
            {
                MessageBox.Show("All fields required");
            }
            else
                AddRatedMovie();
        }


        public void AddRatedMovie()
        {
            using (var context = new MovieContext())
            {
                string[] arr = new string[8];
                ListViewItem item;


                var userMovie = new UserMovie();

                var selectedId = long.Parse(userIDComboBox.SelectedItem.ToString());
                var selectedMovie = moviesComboBox.SelectedItem.ToString();
                var selectedRate = long.Parse(ratingsComboBox.SelectedItem.ToString()!);

                userMovie.User = context.Users.FirstOrDefault(u => u.Id == selectedId)!;
                userMovie.Movie = context.Movies.FirstOrDefault(m => m.Title == selectedMovie)!;
                userMovie.Rating = selectedRate;
                userMovie.RatedAt = DateTime.Now.Date;


                arr[0] = userMovie.User.Id.ToString();
                arr[1] = userMovie.User.Age.ToString();
                arr[2] = userMovie.User.Gender;
                arr[3] = userMovie.User.ZipCode;
                arr[4] = userMovie.User.Occupation.Name;
                arr[5] = selectedMovie!;
                arr[6] = userMovie.Rating.ToString();
                arr[7] = userMovie.RatedAt.ToString();

                item = new ListViewItem(arr);
                ratedMovieListView.Items.Add(item);



                context.UserMovies.Add(userMovie);
                context.SaveChanges();


            }
        }

        public void ListView()
        {
            ratedMovieListView.Columns.Add("UserID", 150);
            ratedMovieListView.Columns.Add("Age", 100);
            ratedMovieListView.Columns.Add("Gender", 150);
            ratedMovieListView.Columns.Add("Zip", 150);
            ratedMovieListView.Columns.Add("Occupation", 250);
            ratedMovieListView.Columns.Add("Movie", 800);
            ratedMovieListView.Columns.Add("Rating", 150);
            ratedMovieListView.Columns.Add("Rated Date", 650);
            ratedMovieListView.GridLines = true;
        }


        public void DisplayUserId()
        {

            using (var context = new MovieContext())
            {
                foreach (var id in context.Users)
                {
                    userIDComboBox.Items.Add(id.Id);
                }
            }
        }

        public void DisplayMovies()
        {
            using (var context = new MovieContext())
            {
                foreach (var movies in context.Movies)
                {
                    moviesComboBox.Items.Add(movies.Title);
                }
            }
        }


        public void RateLevel()
        {
            List<string> nums = new List<string> { "1", "2", "3", "4", "5" };

            foreach (var num in nums)
            {
                ratingsComboBox.Items.Add(num);
            }
        }

        private void moviesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
