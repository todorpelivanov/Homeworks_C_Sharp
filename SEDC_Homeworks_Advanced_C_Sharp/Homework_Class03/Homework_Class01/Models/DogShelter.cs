﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class01.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();

        public static void PrintAll()
        {
            Console.WriteLine("Showing all of the dogs in the Shelter: ");

            for (int i = 0; i < Dogs.Count; i++)
            {
                Console.WriteLine($" ID:{Dogs[i].Id}) Name: {Dogs[i].Name} - Color: {Dogs[i].Color} ");
            }
        }

    }
}
