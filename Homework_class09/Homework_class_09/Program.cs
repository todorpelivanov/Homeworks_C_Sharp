using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework_class_09
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();
            for ( int counter = 1; counter <=5; counter++)
            {
                Console.WriteLine($"enter number {counter}");
                bool Success = int.TryParse(Console.ReadLine(), out int parsedNum);
                if(!Success)
                {
                    Console.WriteLine("Please enter valid number");
                }
                else
                {
                    intQueue.Enqueue(parsedNum);
                }
            }

            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            ////////////TASK 2///////////////// da ne pravam poseben project za malku linii kod mislam deka nema potreba za domasnovo
            //LIST
            List<int> numbersList = new List<int>();
            numbersList.Add(7);
            numbersList.Add(99);
            numbersList.Add(71);
            numbersList.Add(42);
            numbersList.Add(49);
            numbersList.Add(69);
            numbersList.Add(15);
            numbersList.Add(21);
            numbersList.Add(33);
            numbersList.Add(80);
            numbersList.Add(58);

            foreach (int item in numbersList)
            {
                Console.WriteLine(item);
            }

            List<int> squaredNumList = numbersList.Select(n => n * n).ToList();
            foreach (int num in squaredNumList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
