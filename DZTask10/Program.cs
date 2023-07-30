// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

// int firstDigit=number/100;
// int thirdDigit=number%10;
// int result=firstDigit*10+thirdDigit;
// Console.WriteLine($"Результат удаления второй цифры -> {result}");


int result=DelSecondDigit(number);
Console.WriteLine($"результат удаления второй цифры -> {result}");

int result1=DelSecondDigit(567);
Console.WriteLine($"результат удаления второй цифры -> {result1}");

int DelSecondDigit(int num)
{
    int firstDigit=num/100;
    int thirdDigit=num%10;
    return firstDigit*10+thirdDigit;
}