//принимает на входе два числа и пределяет является ли второе число кратны первому. Если не кратное то выводит остаток от деления
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    if(a % b == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        int result = a % b;
        Console.WriteLine("Не кратное. Остаток равен " + result);
    }
}
else
 if(b % a == 0)
    {
        Console.WriteLine("Кратное");
    }
    else
    {
        int result = b % a;
        Console.WriteLine("Не кратное. Остаток равен " + result);
    }