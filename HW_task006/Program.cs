﻿/*
Домашнее задание. 
Задача №6: Напишите программу, которая на вход принимает число и выдает, 
является ли число четным (делится ли оно на два без остатка).
Пример:
4 -> да
-3 -> нет 
7 -> нет
*/
Console.Clear();
Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

if(numberA%2 == 0)
{
  Console.Write("да");
}
else
{
  Console.Write("нет");
}