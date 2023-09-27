/*Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.WriteLine("Введите любое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}