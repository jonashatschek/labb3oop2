using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieService
{
    public class Movie
    {
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public double Rating { get; set; }
        public int NumberOfUserVotes { get; set; }
        public ICollection<Category> Categories { get; set; }

        public Movie()
        {

            Categories = new List<Category>();

        }
        
    }
}