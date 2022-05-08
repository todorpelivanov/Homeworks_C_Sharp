using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class01.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public static bool Validate(Dog validate)
        {
            return validate.Id > 0 && validate.Name.Length >= 2 && validate.Color != string.Empty;
        }

        public void Bark()
        {
            Console.WriteLine($" BARK BARK {Name} is barking, BARK!");
        }
    }
}
