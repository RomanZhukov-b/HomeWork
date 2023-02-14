//Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("First number:-> ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Second number:-> ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
if (max < number2)
    max = number2;
Console.WriteLine($"Максимальная цифра:-> {max} ");

    
 