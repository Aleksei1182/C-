// Программа создаёт массив из N элементов (вводит пользователь от 1 до 10) и заполняет его случайными числами от 1 до 10, после этого выводит на эран среднеарифметическое  всех чётных его элементов 

void FillArray(int[] arr, int len)                 //Имя функции, возвращаемое значение, параметры
//void - пустое значение. Означает что функция ничего не возвращает.
{
for (int i = 0; i < len; i++)
{
    arr[i] = new Random(). Next(1, 11);
    Console.Write(arr[i] + ", ");
}
Console.WriteLine();
}

Console.WriteLine("Введите число от 1 до 10: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

FillArray(array, N); // Вместо ниже написанного вставляем функцию и определяем её параметры "FillArray"

/*for (int i =0; i < N; i++)
{
    array[i] = new Random(). Next(1, 11);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
*/
int sum = 0;
float result = 0; // ввели float чтобы числа не округлялись
int countOfEvens = 0;
for (int i =0; i<N; i++)
{
    if (array[i] % 2 == 0)
    {
        sum += array[i];
        countOfEvens++;
    }
}

result = (float)sum / countOfEvens; // ввели float чтобы числа не округлялись
Console.WriteLine(result);