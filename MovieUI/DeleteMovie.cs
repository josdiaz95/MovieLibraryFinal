using MovieLibraryEntities.Context;


namespace MovieUI
{
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void searchMovieButton_Click(object sender, EventArgs e)
        {
            if (movieSearchTextBox.Text == "Enter keyword" || movieSearchTextBox.Text == null || movieSearchTextBox.Text == "")
            {
                MessageBox.Show("All fields required");
            }
            else
            {
                findMovieToDelete();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (movieUpgradeListBox.SelectedItem == null)
            {
                MessageBox.Show("You must select an item to delete");
            }
            else
            {
                DeletingMovie();
            }

        }


        public void DeletingMovie()
        {
            using (var context = new MovieContext())
            {

                var selected = movieUpgradeListBox.SelectedItem.ToString();
                var deleteMovie = context.Movies.FirstOrDefault(m => m.Title == selected);

                if (deleteMovie != null)
                {
                    context.Movies.Remove(deleteMovie);
                    context.SaveChanges();

                    if (true)
                        this.movieUpgradeListBox.Items.RemoveAt(this.movieUpgradeListBox.SelectedIndex);

                    MessageBox.Show("Movie Deleted:\n" + deleteMovie.Title);
                }
                else
                {
                    Console.WriteLine("Movie not deleted.");
                }
            }
        }


        public void findMovieToDelete()
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

        private void movieSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            movieSearchTextBox.Clear();
        }
    }
}
