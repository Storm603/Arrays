using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] arrN = new int[range];

            for (int i = 0; i < arrN.Length; i++)
            {
                arrN[i] = int.Parse(Console.ReadLine());
            }

            for (int i = arrN.Length; i > 0; i--)
            {
                Console.Write(arrN[i - 1] + " ");
            }
        }
    }
}
