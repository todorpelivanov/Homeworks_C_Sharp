using System;
using System.Runtime.ConstrainedExecution;
using Domain.Enums;
using Domain.Models;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                FirstName = "Marko",
                LastName = "Markovski",
                Role = RoleEnum.Other
            };
            employee.PrintInfo();

            SalesPerson salesPerson = new SalesPerson("Bob", "Bobsky");
            salesPerson.AddSuccessRevenue(300);
            //GetSalary from SalesPerson is called
            Console.WriteLine(salesPerson.GetSalary());

            Manager manager = new Manager("Bill", "Billsky", 700);
            //GetSalary from Manager is called
            Console.WriteLine(manager.GetSalary());
            manager.AddBonus(200);
            manager.AddBonus(100);
            //GetSalary from Manager is called
            Console.WriteLine(manager.GetSalary());

            ///// for homework /////////////

            Contractor ctr1 = new Contractor("Bob", "Bobert", 1000, RoleEnum.Other);
            Contractor ctr2 = new Contractor("Rick", "Rickert", 1000, RoleEnum.Other);
            Manager mng1 = new Manager("Mona", "Monalisa", 1000);
            Manager mng2 = new Manager("Igor", "Igosky", 1000);
            SalesPerson slp1 = new SalesPerson("Lea", "Leova");

            Employee[] employees = new Employee[] { ctr1, ctr2, mng1, mng2, slp1 };

            CEO ceo = new CEO("Ron", "Ronsky", 1500, employees, 10, RoleEnum.CEO);
            ceo.AddSharesPrice(140);
            Console.WriteLine("=========");
            ceo.PrintInfo();
            Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");
            ceo.PrintEmployees();
            Console.WriteLine("=========");


        }
    }
}
