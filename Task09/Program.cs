// 9. Напишите программу, которая выводит
// a) случайное число из отрезка [10, 99] и 
// b) показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99->{number}");
// int firstDigit = number/10;
// int secondDigit = number%10;
// if (firstDigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа ->{firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int MaxDigit = firstDigit>secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {MaxDigit}");


int result = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра числа->{result}");
int result1 = MaxDigit (98);
Console.WriteLine($"Наибольшая цифра числа->{result1}");
int result2 = MaxDigit (35);
Console.WriteLine($"Наибольшая цифра числа->{result2}");
int result3 = MaxDigit (78);
Console.WriteLine($"Наибольшая цифра числа->{result3}");
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int MaxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return MaxDigit;
}