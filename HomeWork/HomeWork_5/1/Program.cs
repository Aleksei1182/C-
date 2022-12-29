// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


/*int AmountOfNumbers = 10; // В программе хочу контролировать кол-во цифр в массиве, поэтому ввожу их переменной
int[]MaasivOfThreeDigitNumbers = new int[AmountOfNumbers]; // идентифицирую массив из "трёхзначных" чисел
int i = 0;
int NumberOfEvenNumbers = 0;
while (i < AmountOfNumbers)
{
    MaasivOfThreeDigitNumbers[i] = new Random().Next(100, 1000); //заполненяю массив трёхзначными числами.
    Console.WriteLine(MaasivOfThreeDigitNumbers[i]);
    if (MaasivOfThreeDigitNumbers[i] % 2 == 0)
    {
        NumberOfEvenNumbers++;
    }
    i++;
}
Console.WriteLine("Колличество чётных чисел в массиве равно "+ NumberOfEvenNumbers);*/

//ПЕРЕДЕЛАЛ НА КОД ОБРАЩАЮЩИЙСЯ К МЕТОДУ

void SpecifiesNumberOfEvenNumbers(int[] arr)// метод, который показывает кол-во чётных цифр в массиве.
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0) count++;    
}
Console.WriteLine("Колличество чётных чисел в массиве равно "+ count);
}


int[]MaasivOfThreeDigitNumbers = new int[10]; 
for (int i = 0; i < 10; i++)
{
    MaasivOfThreeDigitNumbers[i] = new Random().Next(100, 1000); //заполненяю массив трёхзначными числами.
    Console.WriteLine(MaasivOfThreeDigitNumbers[i]);
}

SpecifiesNumberOfEvenNumbers(MaasivOfThreeDigitNumbers);
