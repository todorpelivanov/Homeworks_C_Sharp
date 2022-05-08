using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Bonus_class10.Models;
using Bonus_class10.Enums;


namespace Bonus_class10.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }
        public Cinema() {}
        public Cinema(string name, int halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = movies;
        }

        public string MoviePlaying(Movie movie)
        {
            return $"Watching {movie.Title}";
        }
    }
}
