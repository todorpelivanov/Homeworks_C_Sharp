using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, -20, 54, 95, -90, 33, -41, -67, 98, -12 };

            int maxNum = intArray[0];
            int minNum = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > maxNum)
                {
                    maxNum = intArray[i];
                }
                if (intArray[i] < minNum)
                {
                    minNum = intArray[i];
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
        }
    }
}
