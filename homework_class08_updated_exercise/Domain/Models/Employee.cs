using System;
using Domain.Enums;

namespace Domain.Models
{
    public class Employee
    {
        protected double Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }

        public Employee() {}

        public Employee(double salary, string firstName, string lastName, RoleEnum role)
        {
            Salary = salary;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Salary: {Salary}$.");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
