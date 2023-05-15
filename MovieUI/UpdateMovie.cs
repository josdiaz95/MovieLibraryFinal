using MovieLibraryEntities.Context;
namespace MovieUI
{
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();

        }

        private void searchMovieButton_Click_1(object sender, EventArgs e)
        {
            if (movieSearchTextBox == null || movieSearchTextBox.Text == "" || movieSearchTextBox.Text == "Enter title")
            {
                MessageBox.Show("Error!You must enter a keyword!");
            }
            else
            {
                findMovieToUpdate();
                movieSearchTextBox.Clear();
            }
        }

        private void saveUpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (movieUpgradeListBox.SelectedItem == null)
                {
                    MessageBox.Show("You must select an item to update");
                }
                else
                {
                    UpdatingMovie();
                    updateTitleTextBox.Clear();
                    updateTimePicker.Value = DateTime.Now;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        public void findMovieToUpdate()
        {
            movieUpgradeListBox.Items.Clear();
            using (var context = new MovieContext())
            {

                string movieSearch = movieSearchTextBox.Text.Trim();

                var movieList = context.Movies.ToList();

                var foundMovies = movieList.Where(m =>
                    m.Title.Contains(movieSearch, StringComparison.InvariantCultureIgnoreCase)).ToList();

                if (foundMovies.Any())
                {
                    foreach (var m in foundMovies)
                    {
                        movieUpgradeListBox.Items.Add($"{m.Title}");
                    }
                }
                else
                {
                    MessageBox.Show("\nMovie not found.");
                }
            }
        }

        public void UpdatingMovie()
        {
            using (var context = new MovieContext())
            {
                var selected = movieUpgradeListBox.SelectedItem.ToString();
                var updateMovie = context.Movies.FirstOrDefault(m => m.Title == selected);

                if (updateMovie != null)
                {
                    var newMovie = FirstLetterCap(updateTitleTextBox.Text);
                    updateMovie.ReleaseDate = updateTimePicker.Value;
                    updateMovie.Title = newMovie + $" ({updateMovie.ReleaseDate.Year})";
                    MessageBox.Show("Update:\n" + updateMovie.Title);
                    context.Movies.Update(updateMovie);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Movie not updated!");
                }

            }
        }
        static string FirstLetterCap(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }
    }
}
