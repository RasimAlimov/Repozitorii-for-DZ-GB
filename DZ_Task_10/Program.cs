﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSecondDigitofNumber(int number)
{
    int firstDigit = number /10;
    int secondDigit = firstDigit%10;
    return secondDigit;
}

int secondnumber = GetSecondDigitofNumber(number);
Console.WriteLine($"Вторая цифра введенного трехзначнеого числа: {secondnumber}");
