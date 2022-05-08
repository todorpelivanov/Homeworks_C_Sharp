using System;
using Exercise2.Methods;
using System.Linq;
using System.Collections.Generic;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime userDateTime = UserTimeInput.UserTime();
            Console.WriteLine($"{userDateTime}");

            List<DateTime> holidays = NonWorkingDays.NonWorkingHolidays();

            HolidayChecker.CheckIfNonWorkingDay(holidays, userDateTime);

        }

        
    }
}
