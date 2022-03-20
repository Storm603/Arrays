using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length];
            int i = 0;
            int counter = 0;

            if (nums.Length == 1)
            {
                Console.Write(nums[0]);
                return;
            }

            while (true)
            {
                if (i == nums.Length - 1 - counter)
                {
                    nums[i] = 0;
                    condensed[i] = 0;
                    i = 0;
                    counter++;
                    if (nums.Length - 1 - counter == nums[1])
                    {
                        Console.WriteLine(nums[0]);
                        break;
                    }
                }

                condensed[i] = nums[i] + nums[i + 1];
                nums[i] = condensed[i];

                i++;
            }
        }
    }
}
