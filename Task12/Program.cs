﻿// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
// Без метода
// int result=num1%num2;
// if (result==0) Console.WriteLine ("первое число кратно второму");
// else Console.WriteLine ($"первое число не кратно второму, остаток {result}");
// С помощью метода:
// Создавем вызов методу
int result= Remains (num1, num2);
if (result==0) Console.WriteLine ("первое число кратно второму");
else Console.WriteLine ($"первое число не кратно второму, остаток {result}");
// сам метод
int Remains(int number1, int number2)
{
    return number1%number2;
}