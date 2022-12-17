/* Назовём число «интересным» если его произведение цифр делится на их сумму. 
Напишите программу, которая заполняет массив на 10 «интересных» случайных целых чисел от 10 до 1000. 
(каждый эл-т массива – сгенерирован случайно)*/

/*Стратегия решения:
До тех пор пока длинна массива не равна 10 мы генерируем числа 
и берём в массив только те, у которых произведение чисел делится на их сумму без остатка.*/

int GetLengthOfNumber(int val) // эта функция нам потребуется чтобы определить кол-во цифр в сгенерированном числе
{
    int count = 0; //Кол-во цифр
    while(val > 0)
    {
        val = val /10;
        count++;
    }
    return count; // return - возвращаться. Функция возвращает результат "count"
}

int[]ArrayOfIdealNumbers = new int[10]; // идентифицировали массив из "идеальных" чисел
int i = 0;
while (i < 10) //создаём условие использую while так как увеличение i нужно ставить только после выполнения условия if
{
    int N = new Random().Next(10, 1000); // вводим внутри условия создание числа
    //Console.WriteLine(N); //введено для анализа
    int number = N; // вводим дополнительную переменную чтобы сохранить значение N
    int length = GetLengthOfNumber (number); // определяем с помощью функции кол-во цифр в числе
    
    int[] digitsOfNumber = new int[length]; //создаём массив длинной определённой функцией из случайно сгенерированного числа 
    for (int j = 0; j < length; j++) // при помощи функции for наполняем его числами из случайно сгенерированного числа
    {
        digitsOfNumber[j] = number % 10; // для данной задачи нам расположение не важно поэтому для упрощения пусть оно будет перевёрнутым
        number = number / 10;
        //Console.Write(digitsOfNumber[j] + " "); //введено для анализа
    }
    //Console.WriteLine( ); //введено для анализа
            int SumOfArrayNumbers = 0; //определяем ссумму чисел массива
            for (int j = 0; j < length; j++)
            {
                SumOfArrayNumbers = SumOfArrayNumbers + digitsOfNumber[j];
            }
            //Console.Write(SumOfArrayNumbers + " "); //введено для анализа
            //Console.WriteLine(); //введено для анализа
            int ProductOfArrayNumbers = 1; //определяем произведение чисел массива
            for (int j = 0; j < length; j++)
            {
                ProductOfArrayNumbers = ProductOfArrayNumbers * digitsOfNumber[j];
            }
            //Console.WriteLine(ProductOfArrayNumbers + " "); //введено для анализа
    if (ProductOfArrayNumbers % SumOfArrayNumbers == 0 && ProductOfArrayNumbers>0) // добавил ещё условие (ProductOfArrayNumbers>0) так как без него выпадали "некрасивые" цифры с нулями в составе
    {
        ArrayOfIdealNumbers[i] = N;
        Console.Write(ArrayOfIdealNumbers[i] + " ");
        i = i + 1;
    }
}  