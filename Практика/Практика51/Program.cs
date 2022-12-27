// Программа которая принимает, заполняет массив чётными цифрами случайно сгенерированного цисла от 1 000 до 1 000 000.

//Сделали в виде метода

void FillArrayWithDigits(int N, int[] arr)
{
    int count = 0;
    int i = 0;
    while (N > 0)
    {
        int digit = N % 10;
        if (digit % 2 == 0)
        {
            arr[i] = digit;// идёт заполнение массива
            i++;
            count = count + 1;
        }
        N = N / 10;
    }
    return count; // не понимаю как мне передать если войд...
}


int N1 = new Random().Next(1000, 1000001);
Console.WriteLine(N1);

// НЕ МОГУ РАЗОБРАТЬСЯ КАК ПРИМЕНЯТЬ СОЗДАННЫЙ МЕТОД ДЛЯ ДАЛЬНЕЙШЕГО ИСПОЛЬЗОВАНИЯ

int length = FillArrayWithDigits (N1, int[] arr); //Эту строку можно не писать, а сразу в следующей 
//использовать возвращённый результат от функции GetLengthOfNumber - тоесть "count".

int[] digitsOfNumber = new int[length];