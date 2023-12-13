// Урок 7. Рекурсия
// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main(string[] args)
    {
        int m = -5;
        int n = 8;
        PrintNumbers(m, n);
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
}