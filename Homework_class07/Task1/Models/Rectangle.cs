using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Models
{
    class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name, string color, int sideA, int sideB) : base(name, color)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void getArea()
        {
            int area = SideA * SideB;
            Console.WriteLine($"The area of the rectangle is {area}");
        }

        public override void getPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter of the rectangle is {perimeter}");
        }

    }
}
