// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите любое трехзначное число:");

int a = int.Parse(Console.ReadLine());

int firstNumber = a / 100;
int result = (a - (firstNumber * 100))/10;

Console.WriteLine(result);