/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/ 

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int firstDig = number / 100;
int secondDig = (number / 10) % 10;

Console.WriteLine(secondDig);

// -------------------------------------------------------------------------------

/* Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

// --------------------------------------------------------------------------------

/* Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Enter day of the week: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
if (DayNumber < 1 || DayNumber > 7)
{
    Console.WriteLine("Please enter only numbers between 1 and 7");
}
else
{
    if (DayNumber == 6 || DayNumber == 7)
    {
        Console.WriteLine("Yes, it is weekend");
    }
    else
    {
        Console.WriteLine("No, it is working day");
    }
}