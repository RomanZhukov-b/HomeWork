//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.
Console.Clear();
Console.Write("Введите трехзначное число:-> ");
int number = int.Parse(Console.ReadLine());
int a = number%10;


    Console.WriteLine($"последняя цифра:-> {a} ");
