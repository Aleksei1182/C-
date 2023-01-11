/* Задача 1: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

void SortsFromLargestInString(int[,] arr) //данный метод сортирует двумерныймассив от большего к меньшему
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {        
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {            
            int maximumRowNumber = arr[i,j];
            int IndexOfMaximumNumberInRow = j;
            for (int k = j + 1; k < arr.GetLength(1); k++)        
            {                
                if (arr[i,k] > maximumRowNumber) 
                {                    
                    maximumRowNumber = arr[i,k];
                    IndexOfMaximumNumberInRow = k;
                }             
            }
            int temporary = arr[i,j];
            arr[i,j] = maximumRowNumber;
            arr[i,IndexOfMaximumNumberInRow] = temporary;
        }
    }
}


int rowCount = 10;
int columnCount = 10;
int[,] array = new int [rowCount, columnCount];

FillArray(array);
PrintArray(array);
SortsFromLargestInString(array);
Console.WriteLine();
PrintArray(array);