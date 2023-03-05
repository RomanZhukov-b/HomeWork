﻿// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

using System;
using static System.Console;

Console.Write("Введите строку:-> ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:-> ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

Random random = new Random();
int[,] array = new int[5, 5];
WriteLine("Исходный массив:-> ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
{
    array[i, j] = random.Next(10, 99);
Write("{0} ", array[i, j]);
}
WriteLine();
}
    if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
{
WriteLine("Элемент не существует:>  ");
}
    else
{
    WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
}
ReadLine();
 