/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
Данные вводятся с консоли пользователем*/


int[] array = new int[8];

void FillArray(int[] collection)
{
    int index = 0;
    int length = collection.Length;
    while (index < length)
    {
        Console.WriteLine("Введите любое число ");
        collection[index] = Convert.ToInt32(Console.ReadLine());
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