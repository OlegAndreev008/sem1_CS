﻿Console.Write("Введите 3 числа. Число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 числа. Число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3 числа. Число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine($"Максимальное из чисел равно {max}");