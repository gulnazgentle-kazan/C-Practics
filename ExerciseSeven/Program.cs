/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.WriteLine("Напишите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 999)
{
	Console.WriteLine("Напишите любое трехзначное число");
}
else
{
	int numberTwo = number % 10;
	Console.WriteLine(numberTwo);
}
