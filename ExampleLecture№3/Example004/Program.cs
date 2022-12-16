// Упорядочивание элементов в массиве

int[] arr = {1, 5, 6, 5, 9, 8, 8, 7, 1, 7};

void PrintArray(int[] array) //данный метод выводит массив на печать 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); // символ $ означает интерполяцию строк. После неё без пробела ставятся ковычки и внутри них показывается объединяемые параметры
    }
    Console.WriteLine();
}
//PrintArray(arr);


void SelectionSort(int[] array) //данный метод сортирует массив от меньшего к большему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length ; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
//PrintArray(arr);
//SelectionSort(arr);

//PrintArray(arr);


void LargestSelectionSort(int[] array) //данный метод сортирует массив от большего к меньшему
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length ; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
            
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);

LargestSelectionSort(arr);
PrintArray(arr);