Console.Clear();
/*
Домашнее задание. 
Задача №8: Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все четные числа от 1 до N.
Пример:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Введите целое число от 1 до N: ");
int numberN = int.Parse(Console.ReadLine());
int count = 2;
if(numberN == 1)
{
  Console.Write("Нет четных чисел от 1 до N");
}
else
{
  if(numberN%2 == 0)
  {
    while(count < numberN + 1)
    {
      Console.Write(count);
      if(count == numberN)
      {
        Console.Write(" ");
      }
      else
      {
        Console.Write(", ");
      }
      count+=2;
    }    
  }
  else
  {
    while(count < numberN)
    {
      Console.Write(count);
      if(count == numberN - 1)
      {
        Console.Write(" ");
      }
      else
      {
        Console.Write(", ");
      }
      count+=2;
    }    
  }
}
