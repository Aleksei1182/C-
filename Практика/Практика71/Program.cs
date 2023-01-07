// Код создаёт двумерный масссив и возводит в квадрат числа находящиеся на чётных позициях

void ChangeElementsToSquare(int[,] arr) // метод возводит в квадрат все значения находящиеся на чётных позициях в двумерном массиве
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
}

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

int rowCount = 3;
int columnCount = 4;
int[,] array = new int [rowCount, columnCount];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeElementsToSquare(array);
PrintArray(array);