/* 
Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.



2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


*/


Console.WriteLine("Напиши первое число");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напиши второе число");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напиши третье число");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = 0;


if (numberOne > numberTwo && numberOne > numberThree)
{
    max = numberOne;
}
else if (numberTwo > numberOne && numberTwo > numberThree)
{
    max = numberTwo;
}
else if (numberThree > numberOne && numberThree > numberTwo)
{
    max = numberThree;
}


Console.WriteLine(max);
