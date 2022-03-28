using System;
using Task1.Models;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("Rectangle", "Yellow", 10, 7);
            rectangle.getArea();

            rectangle.Position = new int[] { 5, 110 };

            rectangle.Move();
            rectangle.getArea();
            rectangle.getPerimeter();

            Circle circle = new Circle("Big Circle", "White", 50);

            circle.Position = new int[] { 20, 25 };

            circle.Move();
            circle.getArea();
            circle.getPerimeter();
        }
    }
}
