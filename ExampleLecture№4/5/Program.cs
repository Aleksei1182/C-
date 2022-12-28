//

double Factorial(int n) // метод на примере вывода факториала нагалядно нам демонстрирует что такое Рекурсия (Функция циклится)
{
    if(n==1) return 1;
    else return n * Factorial(n-1);
}


for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}