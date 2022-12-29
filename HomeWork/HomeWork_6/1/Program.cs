// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше нуля ввёл пользователь.
// Не использовать массив.
// M=5 ; 0, 7, 8, -2, -2 -> 2
// M=5 ; -1, -7, 567, 89, 223 -> 3

void NumberOfNumbersGreaterZero(int F) //метод определяющий кол-во цифр больше нуля
{
    int count = 0;
    for (int i = 0, j = i + 1; i < F; i++, j++)
    {
        Console.Write("Введите " + j + " число: ");
        int B = Convert.ToInt32(Console.ReadLine());
        if (B > 0) count++;
    }
    Console.WriteLine("Количество чисел больше нуля равно: " + count);
}

Console.Write("Укажите количество чисел, которые вы хотите ввести: ");
int N = Convert.ToInt32(Console.ReadLine());

NumberOfNumbersGreaterZero (N);
