using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public Pet(string name, string breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }

        public abstract string PrintInfo();
    }
}
