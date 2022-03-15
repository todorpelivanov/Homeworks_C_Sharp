using System;

namespace Exercise02_SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] integerArray = new int[6];
            integerArray[0] = 4;
            integerArray[1] = 3;
            integerArray[2] = 7;
            integerArray[3] = 3;
            integerArray[4] = 2;
            integerArray[5] = 8;

            for(int i = 0; i < integerArray.Length; i++)
            {
                if(integerArray[i] % 2 != 1)
                {
                    sum += integerArray[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
