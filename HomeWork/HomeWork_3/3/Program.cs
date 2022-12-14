// Программа, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив выводится на экран.

void CubeTableArray(int[] arr, int len)
{
for (int i = 1; i < len; i++)
{
    //int NumberCubed = Convert.ToInt32(Math.Pow(i , 3)); // метод "Math.Pow" принимает значения типа double, поэтому его необходимо конвертировать,
    int NumberCubed = i * i * i; 
    arr[i] = NumberCubed;
    Console.Write(NumberCubed + ", ");
}
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N+1];

CubeTableArray(array, N+1);


/*for (int i = 1; i < N; i++)
{
        
    //int NumberCubed = Convert.ToInt32(Math.Pow(i , 3)); // метод "Math.Pow" принимает значения типа double, поэтому его необходимо конвертировать,
    int NumberCubed = i * i * i; 
    array[i] = NumberCubed;
    Console.Write(NumberCubed + ", ");
}*/