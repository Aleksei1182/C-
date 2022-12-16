// программа которая помещает цифры произвольного натурального 
//числа в целочисленный массив(массив начинает заполняться 
//с младшего разряда числа)

int GetLengthOfNumber(int val)
{
    int count = 0; //Кол-во цифр
    while(val > 0)
    {
        val = val /10;
        count++;
    }
    return count; // return - возвращаться. Функция возвращает результат "count"
}

int N = new Random().Next(1, int.MaxValue); // int.MaxValue - максимальное число в данном случае около 2 000 000 000
Console.WriteLine(N);

int length = GetLengthOfNumber (N); //Эту строку можно не писать, а сразу в следующей 
//использовать возвращённый результат от функции GetLengthOfNumber - тоесть "count".

int[] digitsOfNumber = new int[length];

for (int i = 0; i < length; i++)
{
    digitsOfNumber[i] = N % 10;
    N = N / 10;
}
/*for (int i = 0; i < length; i++)
{
Console.Write(digitsOfNumber[i] + " ");
}*/
for (int i = length-1; i >= 0; i--) // эта часть делает наоборот
{
Console.Write(digitsOfNumber[i] + " ");
}