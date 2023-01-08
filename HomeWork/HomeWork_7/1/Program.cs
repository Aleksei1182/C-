// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
//Тип данных для элементов выбрать double, наличие ненулевой дробной части обязательно.
//m = 3, n = 4.
//0.5 7.96 -2.78 -0.2
//1.7 -3.3 8.574 -9.9
//8.5 7.87 -7.1 9.15



void FillArrayWithRealNumbers (double[,] arr) // метод создаёт двуметный масси и заполняет его случайными вещественными дробными числами
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(random.NextDouble()* (10 - (-10)) + (-10),3);// Math.Round математическая функция округления в данном случае цифра "3" говорит о кол-ве знаков после запятой
        }
    }
}


void PrintArray (double[,] arr) // метод выводит на печать двумерный массив вещественных чисел
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
double[,] array = new double [rowCount, columnCount];

FillArrayWithRealNumbers(array);
PrintArray(array);