using System;
using System.Collections.Generic;
using System.Text;
using Bonus_class10.Enums;
using Bonus_class10.Models;
using System.Linq;

namespace Bonus_class10.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public GenreEnum Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie() {}
        public Movie(string title, GenreEnum genre, int rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = rating * 5;
        }
    }

}
