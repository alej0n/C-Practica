using System;
using SortedExtensionExtension;

namespace ZP6
{
   public class ArraySorter
    {
        //ТЕХНИКА ДЕЛЕГИРОВАНИЯ
        public delegate void Delegate(int[] array);
        public void SortArray(int[] array, Delegate sortMethod)
        {
            sortMethod(array);
        }
    }

    class Program
    {
        // ВЛОЖЕННЫЙ КЛАСС
        public static class Message
        {
            public static void DisplayMessage()
            {
                Console.WriteLine("Matriz antes de la ordenación:");
            }

            public static void DisplayMessageExtMet()
            {
                // Mostramos el array después de la ordenación
                Console.WriteLine("\nMatriz después de la ordenación (usando método de extensión):");
            }


            public static void DisplayMessageDel()
            {
                // Ahora usaremos la clase anidada y el delegado para delegar la ordenación
                Console.WriteLine("\n\nUsando delegado para delegar la ordenación:");
            }

            
        }

        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 1, 2 };

            
            Message.DisplayMessage(); // ИСПОЛЬЗОВАНИЕ ВЛОЖЕННОГО КЛАССА 
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            // ИСПОЛЬЗОВАНИЕ РАСШИРЯЮЩИЕ МЕТОДЫ
            numbers.SortAscending();
            Message.DisplayMessageExtMet(); // ИСПОЛЬЗОВАНИЕ ВЛОЖЕННОГО КЛАССА 
            //Печатать sorted array с использованием расширяющие методы
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }

            // ИСПОЛЬЗОВАНИЕ ДЕЛЕГАТА
            Message.DisplayMessageDel(); // ИСПОЛЬЗОВАНИЕ ВЛОЖЕННОГО КЛАССА
            ArraySorter sorter = new ArraySorter();// Экземпляр
            ArraySorter.Delegate sortDelegate = array => array.SortAscending(); // Делегат
            sorter.SortArray(numbers, sortDelegate); // Метод Делегат

            // Печатать sorted array с использованием делегата
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
