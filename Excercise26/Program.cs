/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/


Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

int Count(int arg1)
{
    while (number != 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}

Console.WriteLine(Count(number));