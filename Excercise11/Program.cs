/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
Random rnd = new Random();
int number = rnd.Next(99, 1000);
Console.WriteLine(number);
int del1 = (number / 100);
int del2 = number % 10;
int result = del1 * 10 + del2;
Console.WriteLine(result);
