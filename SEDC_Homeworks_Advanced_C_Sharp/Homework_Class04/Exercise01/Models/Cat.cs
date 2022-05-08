using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }

        public int LivesLeft { get; set; }

        public Cat(string name, int age, int livesLeft, bool lazy, string breed) : base(name, breed, age)
        {
            LivesLeft = livesLeft;
            Lazy = lazy;
            Breed = breed;
        }

        public override string PrintInfo()
        {
            if (Lazy)
            {
                return $"{Name} is a lazy cat, has {LivesLeft} lives left.";
            }
            else
            {
                return $"{Name} is not a lazy, has {LivesLeft} lives left.";
            }
        }
    }
}
