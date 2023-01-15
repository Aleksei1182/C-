/*  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 4 5 6 7 8 */

int IntervalAmount(int n1, int n2)
{    
    if(n1 > n2) return 0;
    else return n1 + IntervalAmount(n1+1, n2);
}


Console.WriteLine("Задайте интервал, на котором вы хотите сосчитать сумму цифр" 
+ " (два числа через пробел): ");
var integers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
int first = integers[0];
int second = integers[1];

if (first < second)
{
    Console.WriteLine("Сумма заданного интервала равна: " + IntervalAmount (first, second));
}
else 
{
    Console.WriteLine("Первое число должно быть меньше второго");
}


