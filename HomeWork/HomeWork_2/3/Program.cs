﻿// Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 7 == 0)
{
    if (N % 23 == 0)
    {
        Console.WriteLine("Введённое число делится на 7 и на 23");
    }
    else
    {
        Console.WriteLine("Введённое число делится только на 7");
    }
}
else
{
    Console.WriteLine("Введённое НЕ делится на 7 и на 23");
}