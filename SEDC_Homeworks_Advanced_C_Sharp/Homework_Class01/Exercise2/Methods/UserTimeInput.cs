using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Methods
{
    public class UserTimeInput
    {

        public static DateTime UserTime()
        {
            Console.WriteLine("Please enter a date as it follows:");

            Console.WriteLine("Enter a month: ");
            bool firstSuccess = int.TryParse(Console.ReadLine(), out int month);
            if (!firstSuccess) { Console.WriteLine("Please enter valid number"); }
            if (month > 12 || month <= 0) { Console.WriteLine("Please enter valid month from 1 to 12"); }

            Console.WriteLine("Enter a day: ");
            bool secondSuccess = int.TryParse(Console.ReadLine(), out int day);
            if (!secondSuccess) { Console.WriteLine("Please enter valid number"); }

            Console.WriteLine("Enter a year: ");
            bool thirdSuccess = int.TryParse(Console.ReadLine(), out int year);
            if (!thirdSuccess) { Console.WriteLine("Please enter valid number"); }

            return new DateTime(year, month, day);
        }


    }
}
