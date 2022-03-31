using System;
using Task3.Models;
using Task3.Enums;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal0 = new Animal("Nanook", "White", 3, Gender.Male);
            Animal animal1 = new Animal("Majlo", "Black", 8, Gender.Male);
            Animal animal2 = new Animal("Benny", "Yellow", 6, Gender.Male);
            Animal animal3 = new Animal("Luna", "Brown", 2, Gender.Female);
            Animal animal4 = new Animal("Astor", "Brown", 9, Gender.Male);
            Animal animal5 = new Animal("Chichiwuawua", "Orange", 11, Gender.Female);
            Animal animal6 = new Animal("Rusty", "White", 6, Gender.Male);
            Animal animal7 = new Animal("Aron", "White", 2, Gender.Male);
            Animal animal8 = new Animal("Atos", "Black", 3, Gender.Male);
            Animal animal9 = new Animal("Stella", "White", 4, Gender.Female);
            Animal animal10 = new Animal("Sharko", "Brown", 8, Gender.Male);
            Animal animal11 = new Animal("Lea", "Pink", 8, Gender.Female);

            List<Animal> animals = new List<Animal>()
            {
                animal0, animal1, animal2, animal3, animal4, animal5, animal6, animal7, animal8, animal9, animal10, animal11
            };

            Console.WriteLine("===========List of all the Animals==========");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal name: {animal.Name} Color: {animal.Color} Age: {animal.Age} {animal}");
            }

            Console.WriteLine("===========Names of all the animals aged 5 or more==========");
            List<Animal> animalsAgedFiveOrMore = animals.Where(x => x.Age >= 5).ToList();
            foreach (Animal animal in animalsAgedFiveOrMore)
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine("===========names of the animals that start with 'A'==========");
            List<Animal> startsWithA = animals.Where(x => x.Name.StartsWith('A')).ToList();

            foreach (Animal animal in startsWithA)
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine("===========all male, brown animals==========");
            List<Animal> maleBrownAnimals = animals.Where(x => x.Color == "Brown").Where(y => y.GenderOfAnimal == Gender.Male).ToList();
            foreach (Animal animal in maleBrownAnimals)
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine("===========the first animal whose name is longer than 10 characters==========");
            Animal nameLongerThanTenChars = animals.FirstOrDefault(x => x.Name.Length >= 10);
            Console.WriteLine(nameLongerThanTenChars.Name);
        }
    }
}
