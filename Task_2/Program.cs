﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 >= max && number2 >= number3) max = number2;
if (number3 >= max && number3 >= number2) max = number3;
Console.WriteLine("Max of 3 numbers = " + max);