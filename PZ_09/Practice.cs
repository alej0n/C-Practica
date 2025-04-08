//using System;


//class Practice
//{
//    /*Function*/
//    private static int Sum(int num1, int num2) => num1 + num2;

//    private static void Func()
//    {
//        //Func

//        var delegate1 = Sum;
//        Console.WriteLine(delegate1);
//        Console.WriteLine(delegate1(1, 6) + "\n");

//        //explicit
//        Func<int, int, int> delegate2 = Sum;
//        Console.WriteLine(delegate2);
//        Console.WriteLine(delegate2(2, 6) + "\n");

//        //anonymus
//        Func<int, int, int> delegate3 = delegate (int num1, int num2) { return num1 + num2; };
//        Console.WriteLine(delegate3);
//        Console.WriteLine(delegate3(3, 6) + "\n");

//        //Lambda
//        Func<int, int, int> delegate4 = (/*int*/ num1, num2) => num1 + num2;
//        Console.WriteLine(delegate4);
//        Console.WriteLine(delegate4(4, 6) + "\n");
//    }

//    /*Action*/
//    private static void Log(string message) => Console.WriteLine(message);

//    private static void Action()
//    {
//        var delegate1 = Log;
//        Console.WriteLine(delegate1);
//        delegate1("Hi World 1\n");

//        //Explicit
//        Action<string> delegate2 = Log;
//        Console.WriteLine(delegate2);
//        delegate2("Hi World 2\n");

//        //Anonimus
//        Action<string> delegate3 = delegate (string m) { Console.WriteLine(m); };
//        Console.WriteLine(delegate3);
//        delegate3("Hi World 3\n");

//        //Lambda
//        Action<string> delegate4 = (/*string*/ m) => Console.WriteLine(m);
//        Console.WriteLine(delegate4);
//        delegate4("Hi World 4\n");
//    }

//    /*Predicate*/
//    private static bool IsGreaterThan(int a, int b) => a > b;
//    private static bool IsGreaterThanS(int[] num) => num[0] > num[1];


//    private static void Pred()
//    {
//        var predicator1 = IsGreaterThan;
//        Console.WriteLine(predicator1);
//        Console.WriteLine(predicator1(1, 2) + "\n");

//        //Explicit
//        Predicate<int[]> predicator2 = IsGreaterThanS;
//        Console.WriteLine(predicator2);
//        Console.WriteLine(predicator2(new[] {2, 2 }) + "\n");

//        //Anonimus
//        Predicate<int[]> predicator3 = delegate (int[] num) { return num[0] > num[1]; };
//        Console.WriteLine(predicator3);
//        Console.WriteLine(predicator3(new[] { 3, 2 }) + "\n");

//        //Lambda
//        Predicate<int[]> predicator4 = (/*int[]*/num) => num[0] > num[1];
//        Console.WriteLine(predicator4);
//        Console.WriteLine(predicator4(new[] { 4, 2 }) + "\n");
//    }

//    static void Main()
//    {
//        //Func();
//        //Action();
//        Pred();
//    }
//}
