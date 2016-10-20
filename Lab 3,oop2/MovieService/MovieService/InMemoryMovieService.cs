using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace MovieService
{
    public class InMemoryMovieService : IMovieService
    {

        //two member variables as internal storage
        //for holding movies and categories
        public List<Movie> _movieList = new List<Movie>();
        public List<Category> _categoryList = new List<Category>();

        /// <summary>
        /// InMemoryService class constructor
        /// </summary>
        public InMemoryMovieService()
        {

            //instances of movie objects
            var movie1 = new Movie { Title = "10 Cloverfield Lane", YearOfPublication = 2016,Rating = 7.3,NumberOfUserVotes = 144272 };
            var movie2 = new Movie { Title = "Office Space", YearOfPublication = 1999, Rating = 7.6, NumberOfUserVotes = 500220 };
            var movie3 = new Movie { Title = "Mad Max: Fury Road", YearOfPublication = 2015, Rating = 8.1, NumberOfUserVotes = 1000223 };

            //adds movie instances to internal movie storage
            _movieList.Add(movie1);
            _movieList.Add(movie2);
            _movieList.Add(movie3);

            //instances of category cariables
            var category1 = new Category {Name = "horror"};
            var category2 = new Category {Name = "comedy"};
            var category3 = new Category {Name = "action"};

            //adds movies to internal category storage
            _categoryList.Add(category1);
            _categoryList.Add(category2);
            _categoryList.Add(category3);

            ConnectMovieAndCategory(movie1, category1);
            ConnectMovieAndCategory(movie2, category2);
            ConnectMovieAndCategory(movie3, category3);

        }

        /// <summary>
        /// connects movies to categories and vice versa
        /// </summary>
        /// <param name="movie">input movie object</param>
        /// <param name="category">input category object</param>
        public void ConnectMovieAndCategory(Movie movie, Category category)
        {
            movie.Categories.Add(category);
            category.Movies.Add(movie);

        }

        /// <summary>
        /// fetches all the movies in the internal storage
        /// </summary>
        /// <returns>all the movies in the list</returns>
        public IEnumerable<Movie> AllMovies()
        {
            IEnumerable<Movie> result = from m in _movieList select m;
            return result;
        }

        /// <summary>
        /// fetches all the movies in the internal storage
        /// </summary>
        /// <returns>all the categories in the list</returns>
        public IEnumerable<Category> AllCategories()
        {
            IEnumerable<Category> result = from c in _categoryList
                                           select c;
            return result;
        }

        /// <summary>
        /// gets all the movies from a category
        /// </summary>
        /// <param name="name">category name</param>
        /// <returns>all the movies in that category</returns>
        public IEnumerable<Movie> MoviesFromCategory(string name)
        {
            return _movieList.Where(movie => movie.Categories.Any(cat => cat.Name == name));
        }

        /// <summary>
        /// gets all the movies produced in a distinct year
        /// </summary>
        /// <param name="year">year</param>
        /// <returns>all the movies released in that year</returns>
        public IEnumerable<Movie> MoviesFromYear(int year)
        {
            IEnumerable<Movie> result = from m in _movieList
                               where m.YearOfPublication == year
                               select m;

            return result;
        }

    }
}