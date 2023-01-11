/*Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


void FillArray (int[,] arr) // метод создаёт двуметный масси и заполняет его случайными числами
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(1,10);
        }
    }
}

void PrintArray (int[,] arr) // метод выводит на печать двуметный масси
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


void PrintRowWithSmallerSumInArray(int[,] arr) //данный метод находит и печатает в двумерном массиве строку с наименьшей суммой
{
    int LineWithSmallerSum = 0;
    int MinSumOfRowElements = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {           
        int SumOfRowElements = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {           
            SumOfRowElements = SumOfRowElements + arr[i,j];  
        }
        Console.WriteLine(SumOfRowElements); //данная строка для удобства проверки
        if (i == 0) MinSumOfRowElements = SumOfRowElements;        
              
        else if (SumOfRowElements < MinSumOfRowElements)
        {
            MinSumOfRowElements = SumOfRowElements;
            LineWithSmallerSum = i;
        }
    }
    Console.WriteLine("Сумма всех элементов меньше в строке номер " + LineWithSmallerSum);
}


int rowCount = 10;
int columnCount = 5;
int[,] array = new int [rowCount, columnCount];

FillArray(array);
PrintArray(array);
PrintRowWithSmallerSumInArray(array);

