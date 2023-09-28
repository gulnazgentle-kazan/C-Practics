/*Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = 1;
int Sum(int A)
{
    while (count < A)
    {
        count++;
        result = result * count;

    }
    return result;
}

Console.WriteLine(Sum(a));
