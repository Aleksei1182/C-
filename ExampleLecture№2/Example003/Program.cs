﻿// Нахождение нужного числа в массиве (первого)

int[] array = {1, 3, 4, 8, 15, 4};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index +1;
    index++;
}
