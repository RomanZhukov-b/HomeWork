﻿//Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число:-> ");
string number = Console.ReadLine();
int N = number.Length;

if (N == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number}:-> Палиндром");
    }
    else
    {
        Console.WriteLine($"{number}:-> Не палиндром");
    }
}
else
{
    Console.WriteLine($"Error:-> {number} - Не является пятизначным");
}