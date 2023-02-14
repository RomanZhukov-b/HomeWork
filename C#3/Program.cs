//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("number:-> ");
int number = int.Parse(Console.ReadLine());
if (number%2 ==0)
{
    Console.WriteLine($"{number} четное");
}
else 
{
    Console.WriteLine($"{number} нечетное");
}





