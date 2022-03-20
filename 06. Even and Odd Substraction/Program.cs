using System;
using System.Linq;

namespace _06._Even_and_Odd_Substraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenSum += input[i];
                }
                else if (input[i] % 2 == 1)
                {
                    oddSum += input[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
