using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any number");
            bool firstSuccess = int.TryParse(Console.ReadLine(), out int parsedNumOne);

            if(!firstSuccess || parsedNumOne > 80)
            {
                Console.WriteLine("Enter a valid number and a number smaller than 80!");
            } else
            {
                for(int i = parsedNumOne; i <= 80; i++)
                {
                    if (i % 5 == 0)
                    {
                 Console.WriteLine($"{i}");
                    }
                    if (i == 80)
                    {
                        Console.WriteLine("The limit is reached!");
                    }
                }
            }
        }
    }
}
