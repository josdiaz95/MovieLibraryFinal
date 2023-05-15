using Microsoft.Extensions.Logging;
using MovieLibraryEntities.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLibraryEntities.Models;

namespace MovieUI
{
    public partial class Adduser : Form
    {

        public string Messages { get; set; }

        public Adduser()
        {
            InitializeComponent();
        }

        private void Adduser_Load(object sender, EventArgs e)
        {
            ageTextBox.Text = "18";
            genderTextBox.Text = "Enter gender (M/F)";
            zipCodeTextBox.Text = "Enter zipcode..";
            occupationComboBox.Text = "Select occupation";
            DisplayOccupations();

        }
        private void addMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddingUser();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Messages);
                Messages = "";
            }
        }


        public void AddingUser()
        {
            using (var context = new MovieContext())
            {

                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("All fields required");
                }
                else
                {
                    var user = new User();
                    int age = int.Parse(ageTextBox.Text);
                    string gender = genderTextBox.Text.ToUpper();
                    var zipCode = zipCodeTextBox.Text;


                    if (age < 18 || age > 99)
                    {
                        MessageBox.Show("Valid age required (18-99)");
                    }
                    else
                    {
                        user.Age = age;

                        if (gender == "F" || gender == "M")
                        {
                            user.Gender = gender;
                        }
                        else
                            Messages += "Valid gender required.\n";

                        if (zipCode.Length != 5)
                        {
                            Messages += ("5 digit zip code required.\n");
                        }
                        else
                            user.ZipCode = zipCode;

                        var selected = occupationComboBox.SelectedItem;

                        var addOcc = context.Occupations.FirstOrDefault(m => m.Name == selected);

                        if (addOcc != null)
                        {
                            user.Occupation = addOcc;
                        }
                        else
                            Messages += "Occupation required.\n";

                        context.Users.Add(user);
                        context.SaveChanges();
                        listBox1.Items.Add($"{user.Id} {user.Age} {user.Gender} {user.ZipCode} {user.Occupation.Name}");
                        MessageBox.Show("User successfully added\n");
                    }
                }
            }
        }


        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            ageTextBox.Clear();
        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {
            genderTextBox.Clear();
        }

        private void zipCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            zipCodeTextBox.Clear();
        }


        public void DisplayOccupations()
        {
            using (var context = new MovieContext())
            {
                foreach (var occu in context.Occupations)
                {
                    occupationComboBox.Items.Add(occu.Name);
                }
            }
        }
    }

}
