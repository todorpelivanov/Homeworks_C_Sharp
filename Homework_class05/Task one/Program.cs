using System;

namespace Homework_class05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday as it follows:");
            Console.WriteLine("Enter a month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime inputtedDate = new DateTime(year, month, day);

            static TimeSpan AgeCalculator(DateTime bdate)
            {
                TimeSpan age = DateTime.Today - bdate;
                Console.WriteLine("You are {0} years old", Math.Floor(age.Days / 365.255));

                return age;
            }

            AgeCalculator(inputtedDate);
        }
    }
}
