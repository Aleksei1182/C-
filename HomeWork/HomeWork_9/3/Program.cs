/* Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 (?)
m = 3, n = 2 -> A(m,n) = 29 (?) */


int AckermannFunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return AckermannFunction(n - 1, 1);
    else return AckermannFunction(n - 1, AckermannFunction(n, m - 1));    
}

Console.WriteLine("Для вычисления функции Аккермана задайте два целых, положительных числа через пробел");
var integers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
int first = integers[0];
int second = integers[1];

Console.WriteLine("функция Аккермана равна: " + AckermannFunction (first, second));