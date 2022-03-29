using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;
using Domain.Models;


namespace Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _SharesPrice { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares, RoleEnum role) : base (salary, firstName, lastName, role)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Employees = employees;
            Shares = shares;
        }

        public void AddSharesPrice(double input)
        {
            _SharesPrice = input;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary = Salary + (Shares * _SharesPrice);
        }
    }
}
