// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число:-> ");
int number = int.Parse(Console.ReadLine());
int r =  (( number / 10) % 10);
 

    Console.WriteLine($"Вторая цифра:-> {r} ");
 


    
