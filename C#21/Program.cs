//  Задайте двумерный массив размером m×n, заполненный случайными
//  вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();

Write("Введите количество строк:->  ");
int rows = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов:-> ");
int columns = Convert.ToInt32(ReadLine());
double[,] numbers = new double[rows, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Write(array[i, j] + " ");
        }
     Write("]");
     WriteLine("");
    }
}