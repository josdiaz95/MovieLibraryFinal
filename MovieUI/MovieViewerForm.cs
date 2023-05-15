using MovieLibraryEntities.Context;
using MovieLibraryEntities.Models;
using System.Windows.Forms;

namespace MovieUI
{
    public partial class MovieViewerForm : Form
    {
        public MovieViewerForm()
        {
            InitializeComponent();
        }

        private void movieLibraryButton_Click_1(object sender, EventArgs e)
        {

            if (keyWordSearchTB.Text != "")
            {
                createMovieRadio.Checked = false;
                updateMovieRadio.Checked = false;
                deleteMovieRadio.Checked = false;
                addUserRadio.Checked = false;
                rateMovieRadio.Checked = false;
                SearchMoviesForm searching = new SearchMoviesForm(keyWordSearchTB.Text);

                if (searching.Read() < 1)
                {
                    MessageBox.Show("No movies found!");
                }
                else
                {
                    keyWordSearchTB.Clear();
                    searching.Show();
                }

            }
            else if (createMovieRadio.Checked)
            {

                CreateMovie create = new CreateMovie();
                create.Show();
            }
            else if (updateMovieRadio.Checked)
            {
                UpdateMovie update = new UpdateMovie();
                update.Show();
            }
            else if (deleteMovieRadio.Checked)
            {
                DeleteMovie delete = new DeleteMovie();
                delete.Show();
            }
            else if (addUserRadio.Checked)
            {
                Adduser add = new Adduser();
                add.Show();
            }
            else if (rateMovieRadio.Checked)
            {
                RateMovie rate = new RateMovie();
                rate.Show();
            }
            else if (ratedMoviesRadio.Checked)
            {
                RatedMovies rated = new RatedMovies();
                rated.Show();
            }
            else
            {

                MessageBox.Show("Error! You must enter a keyword  or select an option!");
            }
        }

        private void MovieViewerForm_Load(object sender, EventArgs e)
        {
            keyWordSearchTB.Text = "Enter keyword";
        }

        private void keyWordSearchTB_TextChanged_1(object sender, EventArgs e)
        {
            keyWordSearchTB.Clear();
        }

    
    }
}