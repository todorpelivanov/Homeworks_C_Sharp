using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Methods
{
    public class HolidayChecker
    {

        public static void CheckIfNonWorkingDay(List<DateTime> nonWorkingDay, DateTime userInput)

        {
            bool isDayNonWorking = false;

            foreach (var day in nonWorkingDay)
            {
                if (userInput == day)
                {
                    isDayNonWorking = true;
                }
            }

            if (isDayNonWorking || userInput.DayOfWeek == DayOfWeek.Saturday || userInput.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine($"{userInput.Day}.{userInput.Month}.{userInput.Year} is a non working day! Hurray!");
            }
            else
            {
                Console.WriteLine($"{userInput.Day}.{userInput.Month}.{userInput.Year} is {userInput.DayOfWeek} get up for WORK!");
            }
        }
    }
}
