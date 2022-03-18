using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.models
{
    class human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} is {Age} years old";
        }
    }
}
