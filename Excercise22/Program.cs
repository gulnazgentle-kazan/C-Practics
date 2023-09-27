/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("Введите любое число ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (n >= count)
{
    Console.WriteLine(Math.Pow(count, 2));
    count++;
}
