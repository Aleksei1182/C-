// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int AmountOfNumbers = 10; // В программе хочу контролировать кол-во цифр в массиве, поэтому ввожу их переменной
int[]ArbitraryArray = new int[AmountOfNumbers]; // идентифицирую массив
int i = 0;
int SumOfOddPositions = 0;
while (i < AmountOfNumbers)
{
    ArbitraryArray[i] = new Random().Next(-1000, 1001); //заполненяю массив произвольными числами от -1000 до 1000.
    Console.WriteLine(ArbitraryArray[i]);
    if (i % 2 == 0)
    {}
    else 
    {
        SumOfOddPositions = SumOfOddPositions + ArbitraryArray[i];
    }
    i++;
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна "+ SumOfOddPositions);

