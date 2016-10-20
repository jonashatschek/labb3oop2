using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieService
{
    /// <summary>
    /// class implements the interface and its methods
    /// </summary>
    class CsvMovieService : IMovieService
    {
        CsvParser csvParser;
        public List<Movie> movieStorage; //creates list for csv-movie storage
        public List<Category> categoryStorage; //creates list for csv-category storage

        /// <summary>
        /// CsvMovieService class constructor
        /// </summary>
        public CsvMovieService()
        {
            csvParser = new CsvParser();
            csvParser.ParseCsv();
            movieStorage = csvParser.GetMovies().ToList();
            categoryStorage = csvParser.GetCategories().ToList();

        }

        /// <summary>
        /// fetches all movies and returns them
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Movie> AllMovies()
        {
            IEnumerable<Movie> result = from m in movieStorage select m;
            return result;
        }

        /// <summary>
        /// fetches all categories and returns them
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Category> AllCategories()
        {
            IEnumerable<Category> result = from c in categoryStorage
                                           select c;
            return result;
        }

        /// <summary>
        /// fetches all movies within a specific category
        /// </summary>
        /// <param name="name">name of the category</param>
        /// <returns></returns>
        public IEnumerable<Movie> MoviesFromCategory(string name)
        {
            return movieStorage.Where(movie => movie.Categories.Any(cat => cat.Name == name));
        }

        /// <summary>
        /// takes a year as an argument and returns movie objects that were released that year
        /// </summary>
        /// <param name="year">movie production year</param>
        /// <returns></returns>
        public IEnumerable<Movie> MoviesFromYear(int year)
        {
            IEnumerable<Movie> result = from m in movieStorage
                                        where m.YearOfPublication == year
                                        select m;

            return result;
        }

        /// <summary>
        /// fetches the correct object by movie title and returns in to caller
        /// </summary>
        /// <param name="movie">requested movie</param>
        /// <returns></returns>
        public IEnumerable<Movie> MovieFacts(Movie movie)
        {
            IEnumerable<Movie> result = from m in movieStorage
                                where m.Title == movie.Title
                                select m;

            return result;
        }

        /// <summary>
        /// sorts movies from an external data storage (movieStorage) in either ascending or descending order
        /// </summary>
        /// <param name="numberOfMovies">number of films wanted in toplist</param>
        /// <param name="orderType">decides of the toplist is ascending or descending</param>
        /// <returns></returns>
        public IEnumerable<Movie> SortMoviesByRating(int numberOfMovies, string orderType)
        {
            return orderType == "descending" ? movieStorage.OrderByDescending(movie => movie.Rating).Take(numberOfMovies) 
                : movieStorage.OrderBy(movie => movie.Rating).Take(numberOfMovies);

        }

        /// <summary>
        /// sorts out the 100 most popular movies based on number of votes and rating
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Movie> MostPopularMovies()
        {
            return movieStorage.OrderByDescending(movie => movie.NumberOfUserVotes).ThenByDescending(movie => movie.Rating).Take(100);
        }       

    }
}
