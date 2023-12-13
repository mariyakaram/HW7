// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 6, -9, 12, 15 };
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }
}
