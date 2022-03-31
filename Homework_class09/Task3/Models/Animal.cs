using System;
using System.Collections.Generic;
using System.Text;
using Task3.Enums;

namespace Task3.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Gender GenderOfAnimal { get; set; }

        public Animal() {}

        public Animal(string name, string color, int age, Gender gender)
        {
            Name = name;
            Color = color;
            Age = age;
            GenderOfAnimal = gender;
        }
        
    }
}
