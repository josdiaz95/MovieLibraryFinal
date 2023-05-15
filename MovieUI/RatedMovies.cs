
using MovieLibraryEntities.Context;
using System.Drawing.Drawing2D;



namespace MovieUI
{
    public partial class RatedMovies : Form
    {
        public RatedMovies()
        {

            InitializeComponent();

        }

        private void RatedMovies_Load(object sender, EventArgs e)
        {

            Occupations();
        }
        private void searchMovieButton_Click_1(object sender, EventArgs e)
        {
            if (occComboBox.SelectedItem == null)
            {
                MessageBox.Show("Occupation required");
            }
            else
            {
                listBox1.Items.Clear();
                RatedByOccupation();
            }


        }


        public void RatedByOccupation()
        {


            using (var context = new MovieContext())
            {


                var userList = context.Users.ToList();


                var occGrouping = userList.GroupBy(u => u.Occupation)
                    .Select(g => new
                    {
                        Occupation = g.Key,
                        UserCount = g.Count(),
                    });


                var occupations = occComboBox.SelectedItem.ToString();

                foreach (var oc in occGrouping)
                {
                    if (occupations == oc.Occupation.Name)
                    {
                        var userMovies = context.UserMovies.ToList();
                        var um = userMovies
                            .Where(x => x.User.Occupation.Name == oc.Occupation.Name)
                            .GroupBy(x => x.Movie.Title)
                            .Select(x => new { MovieTitle = x.Key, CountRating = x.Count() })
                            .ToList();

                        var mostRated = um.OrderByDescending(x => x.CountRating)
                            .Take(1);

                        foreach (var u in mostRated)
                        {
                            listBox1.Items.Add(u.MovieTitle + "\n\tNumber of ratings: " + u.CountRating);
                        }
                    }
                }
            }
        }

        public void Occupations()
        {
            using (var context = new MovieContext())
            {
                var occList = context.Occupations.ToList();
                foreach (var o in occList)
                {
                    occComboBox.Items.Add(o.Name);
                }
            }
        }
    }
}
