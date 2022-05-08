using System;
using System.Linq;
using System.Collections.Generic;
using Exercise01.Models;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Nanuk", 3, "Husky", false, "Chicken");
            Dog dog2 = new Dog("Atos", 15, "Labrador", true, "Fish");
            Dog dog3 = new Dog("Aron", 11, "Dalmatian", true, "Soup");
            Dog dog4 = new Dog("Luna", 7, "Husky", true, "Chicken");

            PetStore<Dog> dogStore = new PetStore<Dog>();
            dogStore.Add(dog1);
            dogStore.Add(dog2);
            dogStore.Add(dog3);
            dogStore.Add(dog4);

            Cat cat1 = new Cat("Lea", 5, 4, false, "Street Cat");
            Cat cat2 = new Cat("Tom", 3, 8, true, "Angorcat");
            Cat cat3 = new Cat("Kitty", 8, 3, false, "Persian");
            Cat cat4 = new Cat("Mark", 2, 7, true, "Persian");

            PetStore<Cat> catStore = new PetStore<Cat>();
            catStore.Add(cat1);
            catStore.Add(cat2);
            catStore.Add(cat3);
            catStore.Add(cat4);

            Fish fish1 = new Fish("Nemo", 22, "Goldfish", "Yellow", 2);
            Fish fish2 = new Fish("Zoki", 30, "Minishark", "Grey", 3);
            Fish fish3 = new Fish("Boki", 11, "Goldfish", "Yellow", 1);
            Fish fish4 = new Fish("Poki", 15, "Yellow Hunter", "Orange", 4);

            PetStore<Fish> fishStore = new PetStore<Fish>();
            fishStore.Add(fish1);
            fishStore.Add(fish2);
            fishStore.Add(fish3);
            fishStore.Add(fish4);

            Console.WriteLine("Dogs for buying:");
            dogStore.PrintPets();

            Console.WriteLine("Cats for buying:");
            catStore.PrintPets();

            Console.WriteLine("Fish for buying:");
            fishStore.PrintPets();

            Console.WriteLine("Buy a dog:");

            dogStore.BuyPet("Nanuk");
            dogStore.BuyPet("Atos");
            dogStore.BuyPet("Portos");

            Console.WriteLine("Buy a cat:");

            catStore.BuyPet("Lea");
            catStore.BuyPet("Tom");
            catStore.BuyPet("Ubavka");

            Console.WriteLine("Buy a fish:");

            fishStore.BuyPet("Zoki");
            fishStore.BuyPet("Boki");
            fishStore.BuyPet("Goldie");


            Console.WriteLine("Cats left for buying:");
            catStore.PrintPets();

            Console.WriteLine("Dogs left for buying:");
            dogStore.PrintPets();

            Console.WriteLine("Fish left for buying:");
            fishStore.PrintPets();

        }
    }
}