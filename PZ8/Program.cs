using System;

// Перечисление (Enum)
enum Post
{
    Junior = 160,   // 1 month
    Mid = 320,      // 2 months
    Senior = 480,   // quarter year
    Lead = 960,     // half year
    Manager = 1920  // year
}

class Accountant
{
    //Boxing Method
    public bool AskForBonus(object workerObj, double workedHours)
    {
        // Unboxing object to enum
        if (workerObj is Post worker)
        {
            return workedHours > (int)worker;
        }
        return false;
    }
}

class Program
{
    static double CalculateWorkedHours(DateTime start, DateTime end) //format time
    {
        double totalHours = 0;
        TimeSpan treeDays = TimeSpan.FromDays(3);
        TimeSpan twoDays = TimeSpan.FromDays(2);
        TimeSpan oneDay = treeDays - twoDays;

        while (start.Date <= end.Date)
        {
            if (start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
            {
                totalHours += 8; // 8h per day
            }
            start = start.Add(oneDay); // ::AddDays(1)
        }

        return totalHours;
    }

    static void Main()
    {
        Accountant accountant = new Accountant();

        Console.Write("Enter the position (Junior, Mid, Senior, Lead, Manager): ");

        if (Enum.TryParse(Console.ReadLine(), out Post worker)) // string => Post (return bool)
        {
            Console.Write("Enter the start date (yyyy-MM-dd): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime startTime))
            {
                Console.Write("Enter the end date (yyyy-MM-dd):   ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime endTime))
                {
                    double workedHours = CalculateWorkedHours(startTime, endTime);
                    object workerBoxed = worker; // Boxing
                    bool bonus = accountant.AskForBonus(workerBoxed, workedHours);
                    Console.WriteLine($"Total hours worked: {workedHours:F2}");
                    if (bonus)
                    {
                        Console.WriteLine("The employee is eligible for a bonus!");
                    }
                    else
                    {
                        Console.WriteLine("No bonus awarded.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Invalid end date input.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid start date input.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid position input.");
        }
    }
}
