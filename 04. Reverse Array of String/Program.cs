using System;
using System.Linq;

namespace _04._Reverse_Array_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string[] reversed = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }
        }
    }
}
