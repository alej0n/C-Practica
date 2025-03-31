using System;

class Program
{
    // Declarate delegate
    public delegate int RandomNumberDelegate();

    static void Main()
    {
        Random RandomNumber = new Random();

        // Do array delegates
        //del[0] = null; del[1]=null; del[2]=null; .....
        RandomNumberDelegate[] del = new RandomNumberDelegate[5];

        for (int i = 0; i < del.Length; i++)
        {
            del[i] = delegate { return RandomNumber.Next(1, 101); }; // del[0] :: return RandomNumber.Next(1, 101); 
        }                                                            // del[1] :: return RandomNumber.Next(1, 101);
                                                                     // del[2] :: return RandomNumber.Next(1, 101);
                                                                     // para después que se ejecute la operación


        // Anonim metod 
        //Fun<in,out> n_del = delegate (in _name) {};
        Func<RandomNumberDelegate[], double> calculateAverage = delegate (RandomNumberDelegate[] delArray)
        {
            int sum = 0;
            foreach (var del in delArray)
            {
                sum += del(); // sum += "return RandomNumber.Next(1, 101);"
            }
            return (double)sum / delArray.Length;
        };

        // Calculate среднее значение
        double average = calculateAverage(del);
        Console.WriteLine($"Среднее арифметическое: {average}");
    }
}