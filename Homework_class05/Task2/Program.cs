using System;
using Task2.models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string HumanFirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string HumanLastName = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int HumanAge = Convert.ToInt32(Console.ReadLine());

            human Person = new human(HumanFirstName, HumanLastName, HumanAge);
            Console.WriteLine(Person.GetPersonStats());
        }
    }
}
