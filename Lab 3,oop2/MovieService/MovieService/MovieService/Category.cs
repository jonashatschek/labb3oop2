using System.Collections.Generic;

namespace MovieService
{
    class Category
    {
        private string name;
        private ICollection<Movie> movies;

        public Category(string name, ICollection<Movie> movies)
        {
            var categoryMovieList = new List<Category>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal ICollection<Movie> Movies
        {
            get
            {
                return movies;
            }

            set
            {
                movies = value;
            }
        }
    }
}