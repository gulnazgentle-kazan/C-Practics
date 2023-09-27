/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

d = sqrt ((x2 — x1)^2 + (y2 — y1)^2)
*/

Console.WriteLine("Введите любое число ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2))), 2);

Console.WriteLine(result);