// Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("number:-> ");
int N = int.Parse(Console.ReadLine());
int a = 1;
while (a<=N)
{
    Console.Write($"{a} ");
    a++;
}
