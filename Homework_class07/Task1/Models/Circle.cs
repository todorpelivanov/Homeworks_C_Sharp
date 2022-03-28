using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(string name, string color, int radius) : base(name, color)
        {
            Radius = radius;
        }

        public override void getArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"The area of the circle is {area}");
        }

        public override void getPerimeter()
        {
            double perimeter = Math.PI * Radius * 2;
            Console.WriteLine($"The perimeter of the circle is {perimeter}");
        }

        public override void Move()
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
