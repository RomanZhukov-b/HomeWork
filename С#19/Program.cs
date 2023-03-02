//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
//  больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите числа через пробел:-> ");
int[] el = Console.ReadLine().Split().Select(int.Parse).ToArray();

int countFind(int[] el)
{
int count = 0;
for(int i = 0; i < el.Length; i++)
{
if(el[i] > 0)
count++;
}
return count;
}
Console.WriteLine($"Чисел больше 0:-> {countFind(el)}");