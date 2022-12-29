// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.


/*int AmountOfNumbers = 10; // В программе хочу контролировать кол-во цифр в массиве, поэтому ввожу их переменной
double[]ArbitraryArray = new double[AmountOfNumbers]; // идентифицирую массив вещественных чисел
int i = 0;
Random SluchainoeChislo = new Random();
while (i < AmountOfNumbers)
{
    ArbitraryArray[i] = Math.Round(SluchainoeChislo.NextDouble()* (100 - (-100)) + (-100),2);// Math.Round математическая функция округления в данном случае цифра "2" говорит о кол-ве знаков после запятой
    Console.WriteLine(ArbitraryArray[i]);
    i++;
}

double MaximumArrayNumber = ArbitraryArray[0];
double MinimumArrayNumber = ArbitraryArray[0];
for (int j = 0; j < AmountOfNumbers; j++)
{
    if (ArbitraryArray[j] > MaximumArrayNumber) MaximumArrayNumber = ArbitraryArray[j];
    else if(ArbitraryArray[j] < MinimumArrayNumber) MinimumArrayNumber = ArbitraryArray[j];
}
Console.WriteLine("Максимальный элемент массива " + MaximumArrayNumber);
Console.WriteLine("Минимальный элемент массива " + MinimumArrayNumber);

double DifferenceBetweenMaximumAndMinimum = 0;
DifferenceBetweenMaximumAndMinimum = MaximumArrayNumber - MinimumArrayNumber;
Console.WriteLine("Разницу между максимальным и минимальным элементом массива равна " + DifferenceBetweenMaximumAndMinimum);
*/

//ПЕРЕДЕЛАЛ НА КОД ОБРАЩАЮЩИЙСЯ К МЕТОДУ

void DifferenceBetweenMaximumAndMinimum(double[] arr)// метод, который считает разницу между максимальным и минимальным элементом массива.
{
double MaximumArrayNumber = arr[0];
double MinimumArrayNumber = arr[0];
for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j] > MaximumArrayNumber) MaximumArrayNumber = arr[j];
        else if(arr[j] < MinimumArrayNumber) MinimumArrayNumber = arr[j];
    }
Console.WriteLine("Максимальный элемент массива " + MaximumArrayNumber);
Console.WriteLine("Минимальный элемент массива " + MinimumArrayNumber);

double Difference = MaximumArrayNumber - MinimumArrayNumber;
Console.WriteLine("Разницу между максимальным и минимальным элементом массива равна " + Difference);
}

double[]ArbitraryArray = new double[10];
Random SluchainoeChislo = new Random();
for (int i = 0; i < 10; i++)
{
    ArbitraryArray[i] = Math.Round(SluchainoeChislo.NextDouble()* (100 - (-100)) + (-100),2);// Math.Round математическая функция округления в данном случае цифра "2" говорит о кол-ве знаков после запятой
    Console.WriteLine(ArbitraryArray[i]);
}

DifferenceBetweenMaximumAndMinimum(ArbitraryArray);