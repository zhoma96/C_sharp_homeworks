// Задача 19
// Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно палиндромом 
// (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать 
// НЕЛЬЗЯ.Используем операторы % и /).
// 14212->нет
// 12821->да
// 23432->да

Console.Write("Enter 5 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);

void ReverseNumber(int num)
{
    int LastDig = num % 10;
    int PreLastDig = (num % 100) / 10;
    int FirstDig = num / 10000;
    int SecDig = (num / 1000) % 10;
    if (FirstDig == LastDig && SecDig == PreLastDig)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

if (number < 10000) Console.WriteLine("Wrong, please enter 5 digit number");
else
{
    ReverseNumber(number);
}

// --------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter Xa: "); 
double xa = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter Xb: "); 
double xb = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter Ya: "); 
double ya = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter Yb: "); 
double yb = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter Za: "); 
double za = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Enter Zb: "); 
double zb = Convert.ToDouble(Console.ReadLine()); 
 
void Distance3D(double Xa, double Xb, double Ya, double Yb, double Za, double Zb) 
{ 
    Console.WriteLine(Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2))); 
} 
 
Distance3D(xa, xb, ya, yb, za, zb);

// ------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void NumberCube(double num)
{
    double count = 1;
    while (count < num + 1)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}
Console.Write("Enter number: ");
double number3 = Convert.ToDouble(Console.ReadLine());
NumberCube(number3);
