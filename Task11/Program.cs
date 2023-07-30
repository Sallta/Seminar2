// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трёхзначное число -> {number}");


// int result=DelSecondDigit(number);
// Console.WriteLine($"результат удаления второй цифры -> {result}");

// int result1=DelSecondDigit(856);
// Console.WriteLine($"результат удаления второй цифры -> {result1}");

// int DelSecondDigit(int num)
// {
//     int firstDigit=num/100;
//     int thirdDigit=num%10;
//     return firstDigit*10+thirdDigit;
// }

int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное трёхзначное число из отрезка : {number}");

int firstDigit = number / 100;

int lastDigit = number % 10;

int result = firstDigit * 10 + lastDigit;


Console.WriteLine($"число состоящее из первой и последней цифры {result}");
