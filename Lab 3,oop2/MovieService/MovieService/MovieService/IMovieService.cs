using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MovieService
{
    public interface IMovieService : IEnumerable
    {

        IEnumerable<Movie> AllMovies();
        IEnumerable<Category> AllCategories();
        IEnumerable<Movie> MoviesFromCategory(string name);
        IEnumerable<Movie> MoviesFromYear(int year);
    }
}