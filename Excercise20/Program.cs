﻿/*  
Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.



A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
d = √ (x2 - x1)² + (y2 - y1)² + (z2 - z1)²

*/

Console.WriteLine("Введите любое число ");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число ");
double z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))), 2);

Console.WriteLine(result);
