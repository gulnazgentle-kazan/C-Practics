/* 
Задача 2: Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


*/

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Напиши первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напиши второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.WriteLine("max = " + numberOne);
}
if (numberOne < numberTwo)
{
    Console.WriteLine("max = " + numberTwo);
}
if (numberOne == numberTwo)
{
    Console.WriteLine(numberOne + " и" + numberTwo + " равны");
}