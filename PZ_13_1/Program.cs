using System;
using System.Threading;

namespace PZ_13_1
{
    class Program
    {
        static object _lock = new object();

        static void Main()
        {
            Random random = new Random();
            int num = random.Next(0, 1001); // Random number [0, 1000]
            Thread thread = new Thread(new ParameterizedThreadStart(PrintNumber));
            thread.Start(num); // Pass the number as a parameter to the thread
            num = random.Next(0, 1001);
            thread = new Thread(new ParameterizedThreadStart(PrintNumber));
            thread.Start(num);
            num = random.Next(0, 1001);
            thread = new Thread(new ParameterizedThreadStart(PrintNumber));
            thread.Start(num);
            Console.ReadLine();
        }

        static void PrintNumber(object obj)
        {
            int number = (int)obj;

            // Determine color depending on the range
            ConsoleColor color = ConsoleColor.White;
            if (number > 300 && number <= 600)
                color = ConsoleColor.Green;
            else if (number > 600)
                color = ConsoleColor.Red;

            // Access to Console
            lock (_lock)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {number}");
                Console.ResetColor();
            }
        }
    }
}