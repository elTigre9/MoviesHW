using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesHW.Models;

namespace MoviesHW.Pages
{
    public class IndexModel : PageModel
    {
        // Instantiate your list of lists (arrays)
        public List<Movies> MyMovies { get; set; } = new List<Movies>();
        public string MainTitle { get; set; }
        public string[] Movies1 { get; set; }

        public void OnGet()
        {
            // place lists into your list of lists
            MyMovies.Add(new Movies 
            {
                MovieId = "2345j22lkj3jkl2j3",
                Title = "Total Recall",
                Director = "Paul Verhoeven",
                Rating = 87.5
            });
            MyMovies.Add(new Movies
            {
                MovieId = "2345jweiouhwekl2j3",
                Title = "Lazy King",
                Director = "Kenyatta Hayes",
                Rating = 2.3
            });
            MyMovies.Add(new Movies
            {
                MovieId = "234wes003jkl2j3",
                Title = "Coming To America 2",
                Director = "Charlie Murphy",
                Rating = 90.3
            });

            MainTitle = "Movie Time!";
            Movies1 = new string[] { "Total Recall", "Lazy King", "Coming To America 2" };
        }
    }
}
