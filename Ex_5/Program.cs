﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три числа:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"Найбільше число: {max}");
    }
}
