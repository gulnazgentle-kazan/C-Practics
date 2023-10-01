/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] array = new int[8];

void FillArray(int[] collection)
{
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int index = 0;
    int size = col.Length;
    while (index < size)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}

FillArray(array);
PrintArray(array);