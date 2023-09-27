/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.



645 -> 5
78 -> третьей цифры нет
32679 -> 6


*/

Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет ");
}
if (number < 1000 && number > 99)
{
    Console.WriteLine(number / 100);
}
if (number > 1000)
{
    while (number > 1000)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}