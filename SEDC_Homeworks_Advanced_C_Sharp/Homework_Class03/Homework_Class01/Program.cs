using System;
using System.Linq;
using Homework_Class01.Models;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "Nanook", "Black & White");
            Dog dog2 = new Dog(2, "Atos", "Yellow");
            Dog dog3 = new Dog(3, "Aron", "Black");
            Dog dog4 = new Dog(4, "Luna", "White");
            Dog dog5 = new Dog(5, "Lily", "Brown");

            Console.WriteLine("Checking if the class properties are all Valid");

            Console.WriteLine(Dog.Validate(dog1));
            Console.WriteLine(Dog.Validate(dog2));
            Console.WriteLine(Dog.Validate(dog3));
            Console.WriteLine(Dog.Validate(dog4));
            Console.WriteLine(Dog.Validate(dog5));

            // Adding dogs to the static list

            DogShelter.Dogs.Add(dog1);
            DogShelter.Dogs.Add(dog2);
            DogShelter.Dogs.Add(dog3);
            DogShelter.Dogs.Add(dog4);
            DogShelter.Dogs.Add(dog5);

            // printing all dogs

            DogShelter.PrintAll();

            // making dog nervious so it starts barking

            dog1.Bark();
        }
    }
}