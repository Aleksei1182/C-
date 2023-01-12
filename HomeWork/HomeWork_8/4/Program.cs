/* Задача 4*. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел. 
Напишите программу, которая будет построчно выводить массив. 
Обратите внимание, что максимальный размер такого массива ограничен. 
Проверку эл-та на присутствие в массиве можно вынести в отдельную функцию.
Например,
11 22 78
12 47 96
25 87 88*/

void FillArrayUniqueNumbers (int[,] arr) // метод создаёт двуметный массив и заполняет его случайными двузначными уникальными числами 
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int j = 0;
        while (j < arr.GetLength(1))
        {
            int N = random.Next(10,100);            
            
                for (int i1 = 0; i1 < arr.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < arr.GetLength(1); j1++)
                    {
                        if(arr[i1,j1] == N)
                        {
                        N = random.Next(10,100);
                        i1 = 0;
                        j1 = 0;
                        }
                    }
                }
            arr[i,j] = N;
            j++;
        }
    }
}


void PrintArray (int[,] arr) // метод выводит на печать двуметный массив
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

int rowCount = 9;
int columnCount = 9;
int[,] array = new int [rowCount, columnCount];

FillArrayUniqueNumbers(array);
PrintArray(array);
