// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Enter number 1: ");
// int.TryParse(Console.ReadLine(), out int number1);

// Console.Write("Enter number 2: ");
// int.TryParse(Console.ReadLine(), out int number2);

// int APowerB(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     return result;
// }

// int res = APowerB(number1, number2);
// Console.WriteLine(res);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Enter number: ");
// int.TryParse(Console.ReadLine(), out int number);

// int SumDigits(int num)
// {
//     int sumOfDigs = 0;
//     int counter = 0;
//     for (int i = 0; i < num; i++)
//     {
//         counter = num % 10;
//         sumOfDigs += counter;
//         num = num / 10;
//     }
//     return sumOfDigs;
// }

// int sum = SumDigits(number);
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

void CreateArray(int[] col)
{
    int length = col.Length;
    int index = 0;
    while(index < length)
    {
        col[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[8];
CreateArray(array);
PrintArray(array);
