﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool Square(int number1, int number2)
{
    return number1 == number2 * number2 || number2 = number1 * number1;
}

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

bool result = Square(a,b);
Console.WriteLine(result ? "Да" : "Нет");