using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int parsedNumOne;
            int parsedNumTwo;

            Console.WriteLine("enter first number");
            bool firstSuccess = int.TryParse(Console.ReadLine(), out parsedNumOne);

            Console.WriteLine("enter second number");
            bool secondSuccess = int.TryParse(Console.ReadLine(), out parsedNumTwo);

            Console.WriteLine("enter arithmetic operation (+, -, * or /)");
            string operationOne = Console.ReadLine();

            if (operationOne == "+")
            {
                result = parsedNumOne + parsedNumTwo;
            } 
            else if(operationOne == "-")
            {
                result = parsedNumOne + parsedNumTwo;
            }
            else if (operationOne == "*")
            {
                result = parsedNumOne * parsedNumTwo;
            }
            else if (operationOne == "/")
            {
                result = parsedNumOne / parsedNumTwo;
            }
            else
            {
                Console.WriteLine("Please enter propper arithmetic operation");
            }

            Console.WriteLine(result);
        }
    }
}
