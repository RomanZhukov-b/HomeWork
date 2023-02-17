//Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите день недели:-> ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Понедельник:-> это будний день!");
}
if (num == 2)
{
    Console.WriteLine("Вторник:-> это будний день!");
}
if (num == 3)
{
    Console.WriteLine("Среда:-> это будний день!");
}
if (num ==4)
{
    Console.WriteLine("Четверг:-> это будний день!");
}
if (num ==5)
{
    Console.WriteLine("Пятница:-> это будний день!");
}
if (num ==6)
{
    Console.WriteLine("Суббота:-> это выходной день!");
}
if (num ==7)
{
    Console.WriteLine("Воскрксенье:-> это выходной день!");
}