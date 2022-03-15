using System;

namespace Exercise01_FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum;
            Console.WriteLine("enter first number");
            bool firstSuccess = int.TryParse(Console.ReadLine(), out int parsedNumOne);

            Console.WriteLine("enter second number");
            bool secondSuccess = int.TryParse(Console.ReadLine(), out int parsedNumTwo);

            if(!firstSuccess || !secondSuccess)
            {
                Console.WriteLine("Please enter valid numbers!");
            }
            if(parsedNumOne % 2 == 0 && parsedNumTwo % 2 == 0 || parsedNumOne == 0 || parsedNumTwo == 0)
            {
                sum = parsedNumOne + parsedNumTwo;
                Console.WriteLine($"The sum of {parsedNumOne} and {parsedNumTwo} is {sum}");
            }
            else if (parsedNumOne % 2 != 0 && parsedNumTwo % 2 != 0)
            {
                sum = parsedNumOne * parsedNumTwo;
                Console.WriteLine($"The multiplying of {parsedNumOne} and {parsedNumTwo} is {sum}");
            }
            else if(parsedNumOne % 2 == 1 || parsedNumTwo % 2 == 1 || parsedNumOne == 0 || parsedNumTwo == 0)
            {
                sum = parsedNumOne - parsedNumTwo;
                Console.WriteLine($"The difference of {parsedNumOne} and {parsedNumTwo} is {sum}");
            }
             else
            {
                Console.WriteLine("Something went wrong! Todor, Check you code!");
            }
        }
    }
}
