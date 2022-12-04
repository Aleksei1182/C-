Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = - number1;
while(number2 <= number1)
{
Console.WriteLine(number2);
number2 = number2 + 1;
}