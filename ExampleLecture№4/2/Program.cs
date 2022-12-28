// 

int[,] matrix= new int[3, 4];

//for (int i = 0; i < 3; i++)
// аналог верхней записи показан ниже через "matrix.GetLength(0)"
for (int i = 0; i < matrix.GetLength(0); i++) // "0" говорит нам что речь идёт о строках

{
    //for (int j = 0; j < 4; j++)
    // аналог верхней записи показан ниже через "matrix.GetLength(1)"
    for (int j = 0; j < matrix.GetLength(1); j++) // "1" говорит нам что речь идёт о столбцах
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}

