using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }

        public string FavoriteFood { get; set; }

        public Dog(string name, int age, string breed, bool goodBoi, string favoriteFood) : base(name, breed, age)
        {
            Breed = breed;
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override string PrintInfo()
        {
            if (GoodBoi)
            {
                return $"{Name} is a good boy! Its favorite food is {FavoriteFood}! nom nom nom";
            }
            else
            {
                return $"{Name} is a bad boy! Its favorite food is {FavoriteFood}! nom nom nom";
            }
        }
    }
}
