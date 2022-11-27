// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите любое трехзначное число:");

int a = int.Parse(Console.ReadLine());

if(a < 100 | a > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
int firstNumber = a / 100;
int result = (a - (firstNumber * 100))/10;

Console.WriteLine(result);
}