﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number1 < number2) max = number2;
Console.WriteLine("Max of 2 numbers = " + max);