﻿// программа, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int NumberDigits1 = N;
int count = 0; //Кол-во цифр в числе
    while(NumberDigits1 > 0)
    {
        NumberDigits1 = NumberDigits1 / 10;
        count++;
    }

int[] digitsOfNumber = new int[count];
int NumberDigits2 = N;
for (int i = 0; i < count; i++)
{
    digitsOfNumber[i] = NumberDigits2 % 10;
    NumberDigits2 = NumberDigits2 / 10;
}

int SumOfDivisors = 0;
int j = 0;
while (j < count)
{
    if (digitsOfNumber[j] == 0) j++;
    if (N % digitsOfNumber[j] == 0)
    {
        SumOfDivisors = SumOfDivisors + digitsOfNumber[j];
        j++;
    }
}
Console.WriteLine(SumOfDivisors);