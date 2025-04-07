using System;
using System.Collections;
using System.Collections.Generic;

// Расширяющий метод
public static class NestedClass
{
    //nested metod
    public static T[] GetArray<T>(this List<T> list)
    {
        return list.ToArray();
    }
}

class Program
{
    public static void PrintList<T>(T[] TArray)
    {
        foreach (var item in TArray)
        {
            Console.Write(item + " ");
        }
    }
    static void Main()
    {
        // list of int elements
        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        int[] intArray = intList.GetArray();

        Console.WriteLine("INt elements are:");
        PrintList<int>(intArray);
        Console.WriteLine();

        // list of int elements
        List<string> stringList = new List<string> { "Hello", "World", "!" };
        string[] stringArray = stringList.GetArray();

        PrintList<string>(stringArray);
        Console.WriteLine();

        // list of int,null elements
        /*List<int?> nullableList = new List<int?> { 1, null, 3 };
        int?[] nullableArray = nullableList.GetArray();

        Console.WriteLine("Nullable массив:");
        foreach (var item in nullableArray)
        {
            Console.Write(item?.ToString() ?? "null");
            Console.Write(" ");
        }*/
    }
}
