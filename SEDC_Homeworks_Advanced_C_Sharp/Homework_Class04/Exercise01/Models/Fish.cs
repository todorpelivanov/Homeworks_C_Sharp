using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Models
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public int Size { get; set; }

        public Fish(string name, int age, string breed, string color, int size) : base(name, breed, age)
        {
            Breed = breed;
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Name} is of breed {Breed},its size is {Size} centimeters long, and its color is {Color}";
        }
    }
}
