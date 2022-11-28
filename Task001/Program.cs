﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите любое трехзначное число:");

int a = int.Parse(Console.ReadLine());

if(a < 100 | a > 999) // Если поставить двойное Или - || - то система проверит только первую половину (a < 100) и если она будет True, то вторую (a > 999) даже трогать не будет так как условие "или то или то" уже соблюдено и не нужны лишние расчеты. Тоже самое работает для двойного И - && (если первое False то второе уже нет смысла проверять) 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
int firstNumber = a / 100;
int result = (a - (firstNumber * 100))/10;

Console.WriteLine(result);
}