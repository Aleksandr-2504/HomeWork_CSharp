/*
Домашнее задание. 
Задача №4: Напишите программу, которая на вход 
принимает три числа и выдает максимальное из этих чисел.
Пример:
2, 3, 7 -> 7
44 5 78 -> 78 
22 3 9 -> 22
*/
Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(max > numberB)
{
  if(max > numberC)
  {
    Console.Write(max);
  }
  else
  {
    max = numberC;
    Console.Write(max);
  }
}
else
{
  max = numberB;
  if(max > numberC)
  {
    Console.Write(max);
  }
  else
  {
    max = numberC;
    Console.Write(max);
  }
}

/*
Второй способ решения (в сокращенном варианте):

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(max < numberB) max = numberB;
if(max < numberC) max = numberC;
Console.Write(max);
*/