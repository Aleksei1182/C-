/*Задача 3. Задайте двумерный массив из трехзначных целых чисел (не менее 100 элементов). 
В каждом столбце найдите среднее арифметическое среди тех элементов, 
которые являются палиндромами (если палиндромов нет, то среднее арифметическое считать равным 0).
Полученные средние арифметические занести в одномерный массив.
Например, задан массив:
100 404 504 225
550 478 800 363
505 101 410 479
=> [505, 252.5, 0, 363 ]*/

void FillArray (int[,] arr) // метод создаёт двуметный масси и заполняет его случайными трёхзначными числами
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(100,1000);
        }
    }
}


void PrintTwoDimensionalArray (int[,] arr) // метод выводит на печать двумеpный массив
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


void PrintArray (double[] arr) // метод выводит на печать одномеpный массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}


void PrintArrayMeanArithmeticPalindromes(int[,] arr) // метод находит в каждом столбце среднее арифметическое среди палиндромов, 
//объединяет его в одномерный массив и выводит его на печать.
{
    double[]ArrayMeanArithmeticPalindromes = new double[arr.GetLength(1)]; 

    int k = 0;

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double SumPalindromesInColumn = 0;
        int count = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            int N1 = arr[j,i] / 100;
            int N2 = arr[j,i] % 10;
            if(N1 == N2)
            {
                SumPalindromesInColumn = SumPalindromesInColumn + arr[j,i];
                count++;
            }
        }
        if(count == 0) 
        {
            ArrayMeanArithmeticPalindromes[k] = 0;
            k++;
        }
        else
        {
        ArrayMeanArithmeticPalindromes[k] = SumPalindromesInColumn / count;
        k++;
        }
    }
    Console.WriteLine();
    PrintArray(ArrayMeanArithmeticPalindromes);
}


int rowCount = 11;
int columnCount = 10;
int[,] array = new int [rowCount, columnCount];

FillArray(array);
PrintTwoDimensionalArray(array);
PrintArrayMeanArithmeticPalindromes(array);