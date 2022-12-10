// Программа выводит случайное число из диапазона от 10 до 99 и определяет какая цифра больше в цисле.

int N = new Random().Next(10, 99);
Console.WriteLine(N);

int firstDigit = N / 10;
int secondDigit = N % 10;


if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}