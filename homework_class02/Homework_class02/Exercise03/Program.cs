using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int parsedNumOne;
            int parsedNumTwo;
            int helper;

            Console.WriteLine("enter first number");
            bool firstSuccess = int.TryParse(Console.ReadLine(), out parsedNumOne);

            Console.WriteLine("enter second number");
            bool secondSuccess = int.TryParse(Console.ReadLine(), out parsedNumTwo);

            Console.WriteLine($"Value of first variable is {parsedNumOne} and value of second variable is {parsedNumTwo}");
            Console.WriteLine("Press any key to change the values of the variables");

            Console.ReadLine();

            helper = parsedNumOne;
            parsedNumOne = parsedNumTwo;
            parsedNumTwo = helper;

            Console.WriteLine($"Value of first variable is {parsedNumOne} and value of second variable is {parsedNumTwo}");
        }
    }
}
