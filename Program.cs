// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


void FillAraray(int[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        Console.Write("Enter element: "); 
        arr[i] = Convert.ToInt32(Console.ReadLine()); 
    } 
} 
 
void PrintArray(int[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        Console.Write($"{arr[i]} "); 
    } 
} 
 
int FindElemCount(int[] arr) 
{ 
    int result = 0; 
    for (int i = 0; i < arr.Length; i++) 
    { 
        if (arr[i] > 0) result += 1; 
    } 
    return result; 
} 
 
Console.Write("Enter number of elements: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[number]; 
 
FillAraray(array); 
PrintArray(array); 
Console.WriteLine(); 
int count = FindElemCount(array); 
Console.WriteLine($"Number of elements higher than 0 is = {count}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FillCoordinates(double[] coor) 
{ 
    for (int i = 0; i < coor.Length; i++) 
    { 
        coor[i] = Convert.ToDouble(Console.ReadLine()); 
    } 
} 
 
void PrintArray(double[] arr) 
{ 
    for (int i = 0; i < arr.Length; i++) 
    { 
        Console.Write($"{arr[i]} "); 
    } 
} 
 
double CalcX(double[] coorX) 
{ 
    double x = (coorX[2] - coorX[0]) / (coorX[1] - coorX[3]); 
    return x; 
} 
 
double CalcY(double[] coorX, double sumx) 
{ 
    double y = coorX[3] * sumx + coorX[2]; 
    return y; 
} 
 
 
double[] Coordinates = new double[4]; 
Console.WriteLine("Enter 4 coordinates (b1, k1, b2 и k2): "); 
 
FillCoordinates(Coordinates); 
PrintArray(Coordinates); 
 
Console.WriteLine(); 
double x = CalcX(Coordinates); 
double y = CalcY(Coordinates, x); 
 
Console.WriteLine($"Two lines will intersect at a point with coordinates X: {x}, Y: {y}");
