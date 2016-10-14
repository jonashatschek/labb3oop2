using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieService
{
    class Movie
    {
        private string title;
        private int yearOfPublication;
        private double rating;
        private int numberOfUserVotes;
        private ICollection<Category> categories;

        public Movie(string title, int yearOfPublication, double rating, int numberOfUserVotes, ICollection<Category> categories)
        {
            var movieCategoryList = new List<Movie>();
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public int YearOfPublication
        {
            get
            {
                return yearOfPublication;
            }

            set
            {
                yearOfPublication = value;
            }
        }

        public double Rating
        {
            get
            {
                return rating;
            }

            set
            {
                rating = value;
            }
        }

        public int NumberOfUserVotes
        {
            get
            {
                return numberOfUserVotes;
            }

            set
            {
                numberOfUserVotes = value;
            }
        }

        internal ICollection<Category> Categories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
            }
        }
    }
}