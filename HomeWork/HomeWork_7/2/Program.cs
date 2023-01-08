//  Напишите программу, которая на вход принимает позиции (два индекса) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет


void FillArray (int[,] arr) // метод создаёт двуметный масси и заполняет его случайными числами
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(2,5);
        }
    }
}

void PrintArray (int[,] arr) // метод выводит на печать двумеpный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }   
}

int rowCount = 3;
int columnCount = 4;
int[,] array = new int [rowCount, columnCount];


Console.WriteLine("Введите интересуемую позицию двухмерного массива " + rowCount + "х" + columnCount + 
" (два числа через пробел): ");
var integers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToArray();
int first = integers[0];
int second = integers[1];

if (first > rowCount - 1 && second > columnCount - 1) 
{
    Console.Write("Такого числа в массиве нет. (Первое число должно быть менее " + rowCount + ". ");
    Console.WriteLine("Второе число должно быть менее " + columnCount + ")");
    return;
}
if (first > rowCount - 1) 
{
    Console.WriteLine("Такого числа в массиве нет. (Первое число должно быть менее " + rowCount + ")");
    return;
}


if (second > columnCount - 1) 
{
    Console.WriteLine("Такого числа в массиве нет. (Второе число должно быть менее " + columnCount + ")");
    return;
}

else
{
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Элемент двумерного массива под указанной вами позицией равен " + array[first, second]);
}
