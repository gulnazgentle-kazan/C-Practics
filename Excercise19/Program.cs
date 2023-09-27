/* 
Задача 19: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.



14212 -> нет
23432 -> да
12821 -> да


*/

Console.WriteLine("Введите любое число ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n3 = n / 100 % 10;
int n4 = n / 10 % 10;
int n5 = n % 10;

/*
Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(n5);
*/

if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
