// Программа, которая выводит третью цифру заданного числа (от 1 до 65636) или сообщает, что третьей цифры нет (решение должно быть математическим).

//Console.WriteLine("Введите число от 1 до 65637: ");
//int N = Convert.ToInt32(Console.ReadLine());

int N = new Random().Next(1, 65637);
Console.WriteLine(N);

if (N / 10000 > 0)
{
    int preliminary = N / 100;
    int result = preliminary % 10;
    Console.WriteLine("третья цифра в числе: " + result);
}
else if (N / 1000 > 0)
{
    int preliminary = N / 10;
    int result = preliminary % 10;
    Console.WriteLine("третья цифра в числе: " + result);
}
else if (N / 100 > 0)
{
    int result = N % 10;
    Console.WriteLine("третья цифра в числе: " + result);
}
else
{
    Console.WriteLine("третьей цифры в числе нет ");
}