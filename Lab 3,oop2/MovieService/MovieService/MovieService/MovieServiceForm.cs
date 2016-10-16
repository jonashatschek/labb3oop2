using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieService
{
    public partial class MovieServiceForm : Form
    {
        IMovieService movieService = new InMemoryMovieService();
        InMemoryMovieService inMemoryMovieService = new InMemoryMovieService();

        public MovieServiceForm()
        {
            InitializeComponent();
 
            foreach (var category in inMemoryMovieService._categoryList)
            {
                categories_comboBox.Items.Add(category.Name);
            }

            foreach (var year in inMemoryMovieService._movieList)
            {
                year_comboBox.Items.Add(year.YearOfPublication);
            }        

        }

        /// <summary>
        /// displays all movies in GUI listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllMoviesBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var movie in movieService.AllMovies())
            {
                var input = movie.Title; //TODO: add some more stuff to show in the list later.
                listBox1.Items.Add(input);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// displays all categories in GUI listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllCategories_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var category in movieService.AllCategories())
            {
                var input = category.Name;
                listBox1.Items.Add(input);
            }
        }

        private void categories_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showMoviesFromCategory_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = categories_comboBox.GetItemText(categories_comboBox.SelectedItem);
            foreach (var movie in movieService.MoviesFromCategory(name))
            {
                listBox1.Items.Add(movie.Title);
            }
                
        }

        private void year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showMoviesFromYear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int year = int.Parse(year_comboBox.GetItemText(year_comboBox.SelectedItem));

            foreach (var movie in movieService.MoviesFromYear(year))
            {
                listBox1.Items.Add(movie.Title);
            }
        }
    }
}

