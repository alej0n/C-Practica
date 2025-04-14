using System;
using System.Threading;

namespace PZ_13_2
{
    class Program
    {
        static int counter = 0;

        // obj sincron
        static object lockObject = new object();

        static void Main()
        {
            Thread[] threads = new Thread[10];

            Random random = new Random();

            for (int i = 0; i < threads.Length; i++)
            {
                int value = random.Next(1, 11);

                // лямбда-выражение
                threads[i] = new Thread(() => AddToCounter(value));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine($"The final value of the counter: {counter}");
        }

        static void AddToCounter(int value)
        {
            // Критическая секция
            lock (lockObject)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} add {value}");
                counter += value;
                Thread.Sleep(100);
            }
        }
    }
}