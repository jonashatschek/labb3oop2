using System;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace MovieService
{
    class InMemoryMovieService
    {
        //has the responsibility of retrieving the movies
        //and their categories from the data storage.

        //create two member variables as internal storage
        //for holding movies and categories
        private List<Movie> movieList = new List<Movie>();
        private List<Category> categoryList = new List<Category>();

        public InMemoryMovieService()
        {
            var movie1 = new Movie("10 Cloverfield Lane", 2016, 7.3, 144272, categoryList);
            var movie2 = new Movie("Office Space", 1999, 7.6, 500220, categoryList);
            var movie3 = new Movie("Mad Max: Fury Road", 2015, 8.1, 1000223, categoryList);

            var category1 = new Category("horror", movieList);
            var category2 = new Category("comedy", movieList);
            var category3 = new Category("action", movieList);

        }

        public void ConnectMovieAndCategory(Movie movie, Category category)
        {

        }

        public IEnumerable<Movie> AllMovies { get; }
        public IEnumerable<Category> AllCategories { get; }

        public IEnumerable<Movie> MoviesFromCategory(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> MoviesFromYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}