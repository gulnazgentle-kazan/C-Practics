/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 0;
int Sum(int A)
{
    while (count < A)
    {
        count++;
        result = result + count;

    }
    return result;
}

Console.WriteLine(Sum(a));