using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace MovieService
{
    public class InMemoryMovieService : IMovieService
    {
        //has the responsibility of retrieving the movies
        //and their categories from the data storage.

        //create two member variables as internal storage
        //for holding movies and categories
        public List<Movie> _movieList = new List<Movie>();
        public List<Category> _categoryList = new List<Category>();

        public InMemoryMovieService()
        {

            var movie1 = new Movie { Title = "10 Cloverfield Lane", YearOfPublication = 2016,Rating = 7.3,NumberOfUserVotes = 144272 };
            var movie2 = new Movie { Title = "Office Space", YearOfPublication = 1999, Rating = 7.6, NumberOfUserVotes = 500220 };
            var movie3 = new Movie { Title = "Mad Max: Fury Road", YearOfPublication = 2015, Rating = 8.1, NumberOfUserVotes = 1000223 };

            _movieList.Add(movie1);
            _movieList.Add(movie2);
            _movieList.Add(movie3);

            var category1 = new Category {Name = "horror"};
            var category2 = new Category {Name = "comedy"};
            var category3 = new Category {Name = "action"};

            ConnectMovieAndCategory(movie1, category1);
            ConnectMovieAndCategory(movie2, category2);
            ConnectMovieAndCategory(movie3, category3);

            _categoryList.Add(category1);
            _categoryList.Add(category2);
            _categoryList.Add(category3);

        }

        public void ConnectMovieAndCategory(Movie movie, Category category)
        {
            movie.Categories.Add(category);
            category.Movies.Add(movie);

        }

        public IEnumerable<Movie> AllMovies()
        {
            IEnumerable<Movie> result = from m in _movieList select m;
            return result;
        }

        public IEnumerable<Category> AllCategories()
        {
            IEnumerable<Category> result = from c in _categoryList
                                           select c;
            return result;
        }

        public IEnumerable<Movie> MoviesFromCategory(string name)
        {
            return _movieList.Where(movie => movie.Categories.Any(cat => cat.Name == name));
        }

        public IEnumerable<Movie> MoviesFromYear(int year)
        {
            IEnumerable<Movie> result = from m in _movieList
                               where m.YearOfPublication == year
                               select m;

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}