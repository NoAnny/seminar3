﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N:");
int length = int.Parse(Console.ReadLine()!);
Console.WriteLine("Таблица кубов чисел от 1 до N: ");
for (int i = 1; i < length+1; i++)
{
   Console.WriteLine($"{i}*{i}*{i} ={i * i * i}"); 
}