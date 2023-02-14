// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("First number:-> ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Second number:-> ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Third number:-> ");
int number3 = int.Parse(Console.ReadLine());

   int result = number1;
  if (number2 > result)
  { 
      result = number2;
  }
  if (number3 > result) 
  {
      result = number3;
  }

Console.WriteLine($"Максимальное чило:-> {result} ");
