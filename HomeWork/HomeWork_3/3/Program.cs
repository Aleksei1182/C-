// Программа, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив выводится на экран.

void CubeTableArray(int[] arr, int len)
{
for (int i = 0; i < arr.Length; i++)
{
    //int NumberCubed = Convert.ToInt32(Math.Pow(i+1 , 3)); // метод "Math.Pow" принимает значения типа double, поэтому его необходимо конвертировать,
    int NumberCubed = (i+1) * (i+1) * (i+1); 
    arr[i] = NumberCubed;
    Console.Write(NumberCubed + ", ");
}
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];

CubeTableArray(array, N);


/*for (int i = 0; i < N; i++)
{
        
    //int NumberCubed = Convert.ToInt32(Math.Pow(i , 3)); // метод "Math.Pow" принимает значения типа double, поэтому его необходимо конвертировать,
    int NumberCubed = (i+1) * (i+1) * (i+1); 
    array[i] = NumberCubed;
    Console.Write(NumberCubed + ", ");
}*/