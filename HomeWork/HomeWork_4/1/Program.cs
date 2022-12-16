// Программа, которая принимает на входе два числа (A и B) и возводит число A в натуральную степень B. 
// Не использовать функцию Math.Pow

Console.WriteLine("Введите число, которое вы хотите возвести в спепень: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, которое будет определять степень возведения для первого числа: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ResultOfExponentiation = 1;

for(int i = 0; i < num2; i++)
{
    ResultOfExponentiation = ResultOfExponentiation * num1;
}
Console.WriteLine(ResultOfExponentiation);