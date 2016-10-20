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
        IMovieService movieService = SimpleDI.GetService();

        public MovieServiceForm()
        {
            InitializeComponent();    

        }

        /// <summary>
        /// starts automatically when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MovieServiceForm_Load(object sender, EventArgs e)
        {
            getCategories();
            getYears();
            printAmountOfItemsInList();

        }

        /// <summary>
        /// prints the amount of objects in the listbox
        /// </summary>
        private void printAmountOfItemsInList()
        {
            amountInList_textBox.Text = listBox1.Items.Count + " hits";

        }
        /// <summary>
        /// gets all categories from the csv-files
        /// </summary>
        public void getCategories()
        {
            foreach (var category in movieService.AllCategories())
            {
                categories_comboBox.Items.Add(category.Name);
            }
        }

        /// <summary>
        /// gets the production years from the csv-file
        /// </summary>
        public void getYears()
        {
            foreach (var year in movieService.AllMovies())
            {
                year_comboBox.Items.Add(year.YearOfPublication);
            }
        }

        /// <summary>
        /// sets the info in textboxes beneath the listbox from marked movie-object
        /// </summary>
        /// <param name="movieName">name of movie</param>
        public bool getMovieInfo(string movieName)
        {
            foreach (Movie movie in movieService.AllMovies())
            {
                if (movieName == movie.Title)
                {
                    title_textBox.Text = "Title: " + movie.Title;
                    yearOfPublication_textBox.Text = "Release year: " + movie.YearOfPublication;
                    rating_textBox.Text = "Rating: " + movie.Rating;
                    numberOfVotes_textbox.Text = "Votes: " + movie.NumberOfUserVotes;
                    category_textBox.Text = "Category/ies: " + movie.Categories; //TODO: FIX THIS!
                    printAmountOfItemsInList();
                    return false;

                }

            }
            return true;
        }

        /// <summary>
        /// makes it possible to show in how many movies the input category occur
        /// </summary>
        /// <param name="categoryName">name of category</param>
        public void getCategoryInfo(string categoryName)
        {
            int counter = 0;
            foreach (Category category in movieService.AllCategories())
            {
                if (categoryName == category.Name)
                {
                    foreach (var movie in movieService.MoviesFromCategory(category.Name))
                    {
                        counter++;
                    }
                }
            }

            title_textBox.Text = "Category occurs in " + counter + " movies";

        }

        /// <summary>
        /// function that clears all the infoboxes beneath the listbox
        /// </summary>
        public void clearMovieTextBoxes()
        {
            title_textBox.Clear();
            yearOfPublication_textBox.Clear();
            rating_textBox.Clear();
            numberOfVotes_textbox.Clear();
            category_textBox.Clear();
        }

        /// <summary>
        /// calls a LINQ-function to get and then displays all movies to in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllMoviesBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var movie in movieService.AllMovies())
            {
                var input = movie.Title;
                listBox1.Items.Add(input);
                printAmountOfItemsInList();
            }
        }

        /// <summary>
        /// calls a LINQ-function to get and then displays all categories to in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllCategories_Click(object sender, EventArgs e)
        {
            try
            {
                clearMovieTextBoxes();
                listBox1.Items.Clear();
                foreach (var category in movieService.AllCategories())
                {
                    var input = category.Name;
                    listBox1.Items.Add(input);

                }
                printAmountOfItemsInList();
            }
            catch { }

        }

        /// <summary>
        /// reacts on the event of selecting an index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearMovieTextBoxes();
            string selectedItem = Convert.ToString(listBox1.SelectedItem);
            try
            {
                bool isNotMovie = getMovieInfo(selectedItem);
                if (isNotMovie)
                    getCategoryInfo(selectedItem);
            }

             catch { }
        }


        private void categories_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Gets all movies from a category selected in a combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showMoviesFromCategory_Click(object sender, EventArgs e)
        {
            try {
                listBox1.Items.Clear();
                int counter = 0;

                string name = categories_comboBox.GetItemText(categories_comboBox.SelectedItem);
                foreach (var movie in movieService.MoviesFromCategory(name))
                {
                    listBox1.Items.Add(movie.Title);
                    counter++;
                }
                printAmountOfItemsInList();

            }
            catch
            {
                MessageBox.Show("Jesus: Thou shalt not play with more than one extention at once!");
            }
        }

        private void year_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// makes user able to se all movies from a distinct year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showMoviesFromYear_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int year = int.Parse(year_comboBox.GetItemText(year_comboBox.SelectedItem));
                int counter = 0;
                foreach (var movie in movieService.MoviesFromYear(year))
                {
                    listBox1.Items.Add(movie.Title);
                    counter++;
                }
                printAmountOfItemsInList();

            }
            catch
            {
                MessageBox.Show("Jesus: Thou shalt not play with more than one extention at once!");
            }
        }

        /// <summary>
        /// defines the event of the scrollbar being moved (activated)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amountOfFilmsInRatingList_trackBar_Scroll(object sender, EventArgs e)
        {
            try { 
                if (amountInList_textBox.Text != "")
                {
                    amountOfFilmsInRatingList_trackBar.Maximum = listBox1.Items.Count;
                    amountOfFilmsInRatingList_trackBar.Minimum = 1;
                    amountInFilteredList_textBox.Text = Convert.ToString(amountOfFilmsInRatingList_trackBar.Value);
                }
                else
                    MessageBox.Show("The textbox is empty.");
                }
            catch { }
        }

        /// <summary>
        /// makes it possible for user to write own value  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void amountInFilteredList_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amountOfFilmsInRatingList_trackBar.Value = Convert.ToInt32(amountInFilteredList_textBox.Text);
            }
            catch
            {

            }
        }

        private void amountInList_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Information_groupbox_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// sorts movies after rating in either ascending or descending order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortMoviesAfterRating_button_Click(object sender, EventArgs e)
        {
            try
            {
                string orderType = "";
                int numberOfMovies = Convert.ToInt32(amountInFilteredList_textBox.Text);
                if (ascendingOrder_radioBtn.Checked && numberOfMovies != 0)
                {
                    orderType = "ascending";
                }
                else if (descendingOrder_radioBtn.Checked && numberOfMovies != 0)
                {
                    orderType = "descending";
                }

                listBox1.Items.Clear();

                foreach (var movie in movieService.SortMoviesByRating(numberOfMovies, orderType))
                {
                    listBox1.Items.Add(movie.Title);
                }
                printAmountOfItemsInList();
            }
            catch { }


        }

        /// <summary>
        /// shows a list of the 100 most popular movies based on number of votes and rating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostPopularMovie_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var movie in movieService.MostPopularMovies())
            {
                listBox1.Items.Add(movie.Title);
            }
            printAmountOfItemsInList();

        }
    }
}

