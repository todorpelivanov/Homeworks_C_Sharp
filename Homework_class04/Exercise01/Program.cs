using System;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK ONE

            Console.WriteLine("Please write any word with more than 5 letters");
            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();
            Console.WriteLine(chars);

            if (input.Length > 5)
            {
                for (int i = chars.Length - 5; i < chars.Length; i++)
                {
                    Console.WriteLine(chars[i]);
                }
            } else
            {
                Console.WriteLine("The word must contain 6 or more letters");
            }

            // TASK TWO

            Console.WriteLine("Please write a sentence");
            string input2 = Console.ReadLine();

            string[] splited = input2.Split(' ');
            foreach (string item in splited)
            {
                Console.WriteLine(item);
            }

            //TASK THREE

            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();

            static int SumOfInputNumbers(string input)
            {
                int sum = 0;
                //string[] splittedString = input.Split();
                for (int i = 0; i < input.Length; i++)
                {
                    sum += Int32.Parse(input[i].ToString());
                }
                return sum;
            }
            Console.WriteLine(SumOfInputNumbers(number));

            //TASK FOUR

            static int CalcSum(int num1, int num2)
            {
                return num1 + num2;
            }

            static int CalcSubstract(int num1, int num2)
            {
                return num1 - num2;
            }

            static int CalcMultiply(int num1, int num2)
            {
                return num1 * num2;
            }

            static int CalcDivide(int num1, int num2)
            {
                return num1 / num2;
            }

             static int Calculator(string oper, int number1, int number2)
            {
                if(oper == "+")
                {
                    return CalcSum(number1, number2);
                }
                else if (oper == "-")
                {
                    return CalcSubstract(number1, number2);
                }
                else if (oper == "*")
                {
                    return CalcMultiply(number1, number2);
                }
                else if (oper == "/")
                {
                    return CalcDivide(number1, number2);
                }
                else
                {
                    return 0;
                }
            }

            Console.WriteLine(Calculator("+", 10, 5));
            Console.WriteLine(Calculator("-", 10, 5));
            Console.WriteLine(Calculator("*", 10, 5));
            Console.WriteLine(Calculator("/", 10, 5));

            // TASK FIVE

            int[] intArray = new int[] { 9, 3, 3, 4, 3, 3, 3 };

            int sum = 0;

            for(int i = 0; i < intArray.Length - 1; i++)
            {
                if(intArray[i] == 3 && intArray[i + 1] == 3)
                {
                    sum += 1;
                }
            }

            Console.WriteLine($"Number of times 3 is next to eachother is: {sum}");
        }
    }
}
