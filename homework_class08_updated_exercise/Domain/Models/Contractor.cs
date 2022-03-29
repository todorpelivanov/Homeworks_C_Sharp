using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public object ResponsibleManager { get; set; }

        public Contractor(string firstName, string lastName, double salary, RoleEnum role) : base(salary, firstName, lastName, role)
        {

        }
        public override double GetSalary()
        {
            return Salary;
        }

        public string CurrentPosition(string department)
        {
            return $"Manager responsible for this Contractor {department}";
        }
    }
}
