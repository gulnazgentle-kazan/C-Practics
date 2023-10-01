/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Не использовать Math.Pow() и аналоги!*/
Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B ");
int b = Convert.ToInt32(Console.ReadLine());

int Pow(int A, int B)
{
    int size = 0;
    int result = 1;

    while (size < b)
    {
        result = result * A;
        size++;
    }
    return result;

}

Console.WriteLine(Pow(a, b));
