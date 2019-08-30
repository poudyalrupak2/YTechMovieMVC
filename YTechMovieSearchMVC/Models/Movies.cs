using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YTechMovieSearchMVC.Models
{
    public class Movies
    {
        public string imdbID { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbRating { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Poster { get; set; }
    }
}