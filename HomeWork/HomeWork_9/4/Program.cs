/* Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


void LoopThroughArray (int[,] arr) // метод создаёт двуметный масси и заполняет его случайными трёхзначными числами
{
    int N = 1;
    int i = 0;
    int j = 0;
    int NumberOfCycles = 0;
    
    while(N <= arr.GetLength(1) * arr.GetLength(0))
    {
    
        while (j < arr.GetLength(1) - NumberOfCycles)    
        {
            if(N <= arr.GetLength(1) * arr.GetLength(0))
            {
                arr[i,j] = N;
                N = N + 1;
                j++;
            }
            else return;
        }    
        i++;
        j--;

        while (i < arr.GetLength(0) - NumberOfCycles)    
        {
            if(N <= arr.GetLength(1) * arr.GetLength(0))
            {
                arr[i,j] = N;
                N = N + 1;
                i++;
            }
            else return;
        }        
        i--;
        j--;

        while (j >= 0 + NumberOfCycles)    
        {
            if(N <= arr.GetLength(1) * arr.GetLength(0))
            {
                arr[i,j] = N;
                N = N + 1;
                j--;
            }
            else return;
        }        
        i--;
        j++;

        while (i > 0 + NumberOfCycles)    
        {
            if(N <= arr.GetLength(1) * arr.GetLength(0))
            {
                arr[i,j] = N;
                N = N + 1;
                i--;
            }
            else return;
        }        
        i++;
        j++;
        NumberOfCycles++;
    }
}

void PrintTwoDimensionalArray (int[,] arr) // метод выводит на печать двумеpный массив
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j].ToString("D2") + " "); // .ToString("D2") обеспечивает заполнение 0 до двузначных чисел
        }
        Console.WriteLine();
    }   
}

int rowCount = 4;
int columnCount = 4;
int[,] array = new int [rowCount, columnCount];

LoopThroughArray(array);
PrintTwoDimensionalArray(array);