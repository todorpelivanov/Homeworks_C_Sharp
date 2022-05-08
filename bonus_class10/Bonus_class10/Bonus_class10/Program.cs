using System;
using System.Collections.Generic;
using System.Text;
using Bonus_class10.Enums;
using Bonus_class10.Models;
using System.Linq;

namespace Bonus_class10
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Star Wars I", GenreEnum.SciFi, 5);
            Movie movie2 = new Movie("Star Wars II", GenreEnum.SciFi, 4);
            Movie movie3 = new Movie("Star Wars III", GenreEnum.SciFi, 5);
            Movie movie4 = new Movie("Star Wars IV", GenreEnum.SciFi, 5);
            Movie movie5 = new Movie("Star Wars V", GenreEnum.SciFi, 5);
            Movie movie6 = new Movie("Star Wars VI", GenreEnum.SciFi, 5);
            Movie movie7 = new Movie("Star Wars VII", GenreEnum.SciFi, 3);
            Movie movie8 = new Movie("Star Wars VIII", GenreEnum.SciFi, 2);
            Movie movie9 = new Movie("Star Wars IX", GenreEnum.SciFi, 5);
            Movie movie10 = new Movie("Rush Hour", GenreEnum.Comedy, 5);
            Movie movie11 = new Movie("Die Hard", GenreEnum.Action, 5);
            Movie movie12 = new Movie("Insidious", GenreEnum.Horror, 5);
            Movie movie13 = new Movie("The Ring", GenreEnum.Horror, 5);
            Movie movie14 = new Movie("The Beach", GenreEnum.Drama, 5);
            Movie movie15 = new Movie("Fast And Furious", GenreEnum.Action, 5);
            Movie movie16 = new Movie("Old School", GenreEnum.Comedy, 5);
            Movie movie17 = new Movie("Sky High", GenreEnum.Drama, 5);

        }
    }
}
