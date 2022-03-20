using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] arr = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            int input = int.Parse(Console.ReadLine());


            if (input >= 1 && input <= 7)
            {
                
                Console.WriteLine(arr[input - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
