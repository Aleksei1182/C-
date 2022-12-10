//Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number / 10;
int number3 = number2 % 10;
Console.WriteLine(number3);