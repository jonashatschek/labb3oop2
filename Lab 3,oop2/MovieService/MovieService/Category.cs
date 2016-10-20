using System.Collections.Generic;

namespace MovieService
{
    public class Category
    {
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

        public Category()
        {

            Movies = new List<Movie>();
        }

    }
}