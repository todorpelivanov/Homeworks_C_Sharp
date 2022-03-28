using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    public class Shape
    {
        public string Name;

        public string name
        {
            get { return Name; }
            set
            {
                if (value == "Rectangle" || value == "Circle")
                {
                    Name = value;
                    Console.WriteLine($"Crating a {name}");
                }
                else
                {
                    Name = value;
                }
            }
        }

        public string Color;

        public string color
        {
            get { return Color; }
            set
            {
                if (value == "Blue" || value == "Red" || value == "Yellow" || value == "Black" || value == "Orange" || value == "Green" || value == "Purple" || value == "Pink")

                {
                    Color = value;
                    Console.WriteLine($"With the {color} color!");
                }
                else
                {
                    Color = null;
                }
            }
        }
        public int[] Position { get; set; }

        public Shape()
        {
        }

        public Shape(string name, string color)
        {
            Name = name;
            Color = color;
        }


        public virtual void getArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void getPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public virtual void Move()
        {
            int[] updatedPositions = new int[0];
            int index = 0;

            foreach (int coordinates in Position)
            {
                Array.Resize(ref updatedPositions, updatedPositions.Length + 1);
                updatedPositions[index] = coordinates + 5;
                index++;
            }

#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 0; i < updatedPositions.Length; i++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                Console.WriteLine($"At position: {updatedPositions[0]}, {updatedPositions[1]}");
                break;
            }
        }



    }
}
