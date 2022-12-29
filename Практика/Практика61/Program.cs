// Программа которая меняет местами крайнии числа в массиве


void Swap(ref int a, ref int b) // "ref" даннай функция позволяет передавать на изменение а не просто копировать данные без замены
{
    int tmp = a;
    a = b;
    b = tmp;
}

int[] arr = new int[] {4, 5, 6, 3, 7, 9};
for (int i = 0, j = arr.Length - 1; i < arr.Length/2; i++, j--)
{
    Swap(ref arr[i], ref arr[j]);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}


//Далее вариант с одной переменной
/*
void Swap(ref int a, ref int b) // "ref" даннай функция позволяет передавать на изменение а не просто копировать данные без замены
{
    int tmp = a;
    a = b;
    b = tmp;
}

int[] arr = new int[] {4, 5, 6, 3, 7, 9};
for (int i = 0; i < arr.Length/2; i++)
{
    Swap(ref arr[i], ref arr[arr.Length - 1 - i]);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}*/