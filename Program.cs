// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// int[,] GenerateArray(int m, int n, int min, int max) 
// { 
//     int[,] arrNum = new int[m, n]; 
//     for (int i = 0; i < arrNum.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arrNum.GetLength(1); j++) 
//         { 
//             arrNum[i,j] = new Random().Next(min, max); 
//         } 
//     } 
//     return arrNum; 
// } 

// void PrintArray(int[,] arr) 
// { 
//     for (int i = 0; i < arr.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         { 
//             Console.Write($"{arr[i,j]} "); 
//         } 
//         Console.WriteLine(); 
//     } 
// } 

// int[,] array = GenerateArray(3, 4, 0, 9); 
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (формат ввода произвольный, не обязательно через запятую)

// int[,] GenerateArray(int m, int n, int min, int max) 
// { 
//     int[,] arrNum = new int[m, n]; 
//     for (int i = 0; i < arrNum.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arrNum.GetLength(1); j++) 
//         { 
//             arrNum[i,j] = new Random().Next(min, max); 
//         } 
//     } 
//     return arrNum; 
// } 

// void PrintArray(int[,] arr) 
// { 
//     for (int i = 0; i < arr.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         { 
//             Console.Write($"{arr[i,j]} "); 
//         } 
//         Console.WriteLine(); 
//     } 
// } 

// void FindElementInArray(int[,] array1, int row, int col) 
// { 
//     if (row < array1.GetLength(0) && col < array1.GetLength(1)) 
//     { 
//         Console.WriteLine($"[{row},{col}] = {array1[row, col]}"); 
//     } 
//     else Console.WriteLine($"[{row},{col}], there is no such position in array"); 
// } 

// Console.Write("Enter row numbers: "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Enter column numbers: "); 
// int n = Convert.ToInt32(Console.ReadLine()); 

// int[,] array = GenerateArray(m, n, 0, 9); 

// Console.Write("Enter row(first is 0): "); 
// int row = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Enter column(first is 0): "); 
// int column = Convert.ToInt32(Console.ReadLine()); 

// PrintArray(array); 
// FindElementInArray(array, row, column);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateArray(int m, int n, int min, int max)
{
    int[,] arrNum = new int[m, n];
    for (int i = 0; i < arrNum.GetLength(0); i++)
    {
        for (int j = 0; j < arrNum.GetLength(1); j++)
        {
            arrNum[i, j] = new Random().Next(min, max);
        }
    }
    return arrNum;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(1);)
    {
        double result = 0;
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            result = result + arr2[j, i];
        }
        Console.WriteLine($"Arithmetic mean = {result / arr2.GetLength(0)}");
    i++;
    }
}

int[,] array = GenerateArray(4, 4, 0, 9);
PrintArray(array);
ArithmeticMean(array);
