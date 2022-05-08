using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //making absolute path to location
            string appPAth = Directory.GetCurrentDirectory();

            //checking if folder exists
            bool folderExists = Directory.Exists(appPAth);
            if (folderExists)
            {
                Console.WriteLine($" The folder {appPAth} exists!");
            }
            else
            {
                Console.WriteLine("The folder doesnt exists!");
            }

            //creating new folder
            string NewFolder = appPAth + @"/Exercise";
            if(!Directory.Exists(NewFolder))
            {
                Directory.CreateDirectory(NewFolder);
            }

            //creating the calculation.txt file
            string filesPath = NewFolder + @"/Exercise";
            if (!File.Exists(filesPath + @"Calculations.txt"))
            {
                // We create the file and close the connection
                File.Create(filesPath + @"Calculations.txt").Close();
            }

            int input1;
            int input2;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter two numbers to find the sum");

                Console.Write("Please enter your first number: ");

                while (!int.TryParse(Console.ReadLine(), out input1))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write("Please enter your first number: ");
                }

                Console.Write("Please enter your second number: ");

                while (!int.TryParse(Console.ReadLine(), out input2))
                {
                    Console.WriteLine("Invalid input, please try again.");
                    Console.Write("Please enter your second number: ");
                }

                string result = SumOfTwoNumbers(input1, input2);

                DateTime localDate = DateTime.Now;

                string dateToString = localDate.ToString();

                AddText(filesPath, result, dateToString);
            }

            Console.WriteLine("Reading from text file: ");

            using (StreamReader sr = new StreamReader(filesPath))
            {
                string readContent = sr.ReadToEnd();
                Console.WriteLine(readContent);
            }
        }

        // the method for calculation
        public static string SumOfTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;

            string convResToString = result.ToString();

            return $" Result of {num1} plus {num2} equals {convResToString}";
        }

        //method for writing in the file
        public static void AddText(string path, string result, string date)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if (result == "break")
            {
                throw new Exception("Error");
            }

            sw.WriteLine($"Timestamp: {date} - Calculation: {result}");
            sw.Dispose();
        }
    }
}