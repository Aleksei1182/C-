// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int AmountOfNumbers = 10; // В программе хочу контролировать кол-во цифр в массиве, поэтому ввожу их переменной
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
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна "+ SumOfOddPositions);*/


//ПЕРЕДЕЛАЛ НА КОД ОБРАЩАЮЩИЙСЯ К МЕТОДУ


void SumOfOddArrayPositions(int[] arr)// метод, который считает сумму элементов, стоящих на нечётных позициях.
{
int SumOfOddPositions = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0)
    {}
    else SumOfOddPositions = SumOfOddPositions + arr[i];
}
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях равна "+ SumOfOddPositions);
}


int[]ArbitraryArray = new int[10];

for (int i = 0; i < 10; i++)
{
    ArbitraryArray[i] = new Random().Next(-1000, 1001);
    Console.WriteLine(ArbitraryArray[i]);
}

SumOfOddArrayPositions(ArbitraryArray);