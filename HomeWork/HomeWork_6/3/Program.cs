// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Если кол-во элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.
//1, 3, 8, 3, 2 -> 11
//8, 3, 4, 2 -> 28


void SumProductsOfPairsNumbers(int[] arr)// метод, который считает сумму произведений крайних пар чисел (с приближением к центру).
{
    int Sum = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Sum = Sum + arr[i] * arr[arr.Length-1-i];
    }
    Console.WriteLine("Сумма произведений крайних пар чисел (с приближением к центру) равна: " + Sum);
}

int[]ArbitraryArray = new int[10];

for (int i = 0; i < 10; i++)
{
    ArbitraryArray[i] = new Random().Next(1, 10);
    Console.WriteLine(ArbitraryArray[i]);
}

SumProductsOfPairsNumbers(ArbitraryArray);