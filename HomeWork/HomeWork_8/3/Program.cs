/* Задача 3: Задайте две квадратные матрицы одинакового размера. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица:
18 20
15 18*/


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


void PrintingProductOfTwoMatrices(int[,] arr) //данный метод находит и печатает в двумерном массиве произведение двух массивов
{
    int rowCount = 3;
    int columnCount = 3;
    int[,] array1 = new int [rowCount, columnCount];
    int[,] array2 = new int [rowCount, columnCount];
    FillArray (array1);
    FillArray (array2);
    PrintArray (array1);
    PrintArray (array2);
    int[,] ArrayProductOfTwoMatrices = new int [rowCount, columnCount];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int ProductOfTwoMatrices = 0;
            
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                ProductOfTwoMatrices = ProductOfTwoMatrices + array1[i,rowCount -1 - k] * array2[rowCount -1 - k,j];
            }
            ArrayProductOfTwoMatrices[i,j] = ProductOfTwoMatrices;          
            
          /*ProductOfTwoMatrices[0,0] = array1[0,0] * array2[0,0] + array1[0,1] * array2[1,0]   + array1[0,2] * array2[2,0];
            ProductOfTwoMatrices[0,1] = array1[0,0] * array2[0,1] + array1[0,1] * array2[1,1]   + array1[0,2] * array2[2,1];
            ProductOfTwoMatrices[0,2] = array1[0,0] * array2[0,2] + array1[0,1] * array2[1,2]   + array1[0,2] * array2[2,2];

            ProductOfTwoMatrices[1,0] = array1[1,0] * array2[0,0] + array1[1,1] * array2[1,0]   + array1[1,2] * array2[2,0];
            ProductOfTwoMatrices[1,1] = array1[1,0] * array2[0,1] + array1[1,1] * array2[1,1]   + array1[1,2] * array2[2,1];
            ProductOfTwoMatrices[1,2] = array1[1,0] * array2[0,2] + array1[1,1] * array2[1,2]   + array1[1,2] * array2[2,2];

            ProductOfTwoMatrices[2,0] = array1[2,0] * array2[0,0] + array1[2,1] * array2[1,0]   + array1[2,2] * array2[2,0];
            ProductOfTwoMatrices[2,1] = array1[2,0] * array2[0,1] + array1[2,1] * array2[1,1]   + array1[2,2] * array2[2,1];
            ProductOfTwoMatrices[2,2] = array1[2,0] * array2[0,2] + array1[2,1] * array2[1,2]   + array1[2,2] * array2[2,2];*/
        }
    }
    PrintArray (ArrayProductOfTwoMatrices);
}


int rowCount = 3;
int columnCount = 3;
int[,] array = new int [rowCount, columnCount];

PrintingProductOfTwoMatrices(array);