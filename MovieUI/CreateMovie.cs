using MovieLibraryEntities.Context;
using MovieLibraryEntities.Models;

namespace MovieUI
{
    public partial class CreateMovie : Form
    {
        public CreateMovie()
        {
            InitializeComponent();
        }


        private void addMovieButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "Enter title" || titleTextBox.Text == null || titleTextBox.Text == "")
            {
                MessageBox.Show("All fields required");
            }
            else
            {
                CreatingMovie();
                titleTextBox.Clear();
            }

        }

        public void CreatingMovie()
        {
            try
            {
                using (var context = new MovieContext())
                {
                    var movie = new Movie();
                    var createTitle = FirstLetterCap(titleTextBox.Text);
                    movie.ReleaseDate = releaseDatePicker.Value;
                    movie.Title = createTitle + $" ({movie.ReleaseDate.Year})";

                    context.Add(movie);
                    context.SaveChanges();
                    listBox1.Items.Add(movie.Title);
                    MessageBox.Show("Movie successfully added!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Movie can't be added.");
            }

        }
        static string FirstLetterCap(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }
        private void CreateMovie_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = "Enter title";
        }


        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleTextBox.Clear();
        }

    }


}
