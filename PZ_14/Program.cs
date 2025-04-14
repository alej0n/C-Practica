using System;
using System.Collections.Generic;

namespace PZ_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even numbers in the array:");
            foreach (int even in GetEvenNumbers(numbers))
            {
                Console.Write(even + " ");
            }

            Console.WriteLine();
        }

        // This method returns IEnumerable<int> using the yield operator
        static IEnumerable<int> GetEvenNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
