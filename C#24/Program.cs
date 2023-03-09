// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();

Write("Введите количество строк массива:-> ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива:-> ");
int columns = int.Parse(ReadLine());

int[,] inArray = GetArray(rows, columns, 0, 10);

PrintArray(inArray);


WriteLine("-----------------");


var result = SredArif(inArray);
 for (int j = 0; j < result.Length; j++)
        {
            Write($"{result[j]} ");
        }
        WriteLine();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

double[] SredArif(int[,] inArray)
{
    double sum = 0;
    double[] sredeeArifmet = new double[inArray.GetLength(1)];

    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
            sum = sum + inArray[i, j];
        }

        sredeeArifmet[j] = (double) sum / inArray.GetLength(1);
        sum = 0;

    }
    return sredeeArifmet;
}