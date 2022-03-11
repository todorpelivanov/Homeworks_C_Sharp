using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            int parsedNumOne;
            int parsedNumTwo;
            int parsedNumThree;
            int parsedNumFour;
            int result;

            Console.WriteLine("enter first number");
            bool firstSuccess = int.TryParse(Console.ReadLine(), out parsedNumOne);

            Console.WriteLine("enter second number");
            bool secondSuccess = int.TryParse(Console.ReadLine(), out parsedNumTwo);

            Console.WriteLine("enter third number");
            bool thirdSuccess = int.TryParse(Console.ReadLine(), out parsedNumThree);

            Console.WriteLine("enter fourth number");
            bool fourthSuccess = int.TryParse(Console.ReadLine(), out parsedNumFour);

            result = (parsedNumOne + parsedNumTwo + parsedNumThree + parsedNumFour) / 4;
            Console.WriteLine($"The average result of all 4 numbers is {result}");
        }
    }
}
