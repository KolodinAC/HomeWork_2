﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число от 10 до 999:");

int a = int.Parse(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Вы ввели не трехзначное число, у которого нет третьей цифры");
}
else
{
    String str = a.ToString();
    Console.WriteLine(str[2]);
}