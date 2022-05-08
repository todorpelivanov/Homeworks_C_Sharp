using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Methods
{
    public class NonWorkingDays
    {
        public static List<DateTime> NonWorkingHolidays()
        {
            return new List<DateTime>()
            {
               new DateTime(2022, 1, 1),
                new DateTime(2022, 1, 7),
                new DateTime(2022, 4, 20),
                new DateTime(2022, 5, 1),
                new DateTime(2022, 5, 25),
                new DateTime(2022, 8, 3),
                new DateTime(2022, 9, 8),
                new DateTime(2022, 10, 12),
                new DateTime(2022, 10, 23),
                new DateTime(2022, 12, 8)

            };
        }
    }
}
