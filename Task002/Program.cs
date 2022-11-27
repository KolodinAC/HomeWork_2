// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число от 10 до 999:");

int a = int.Parse(Console.ReadLine());

if (a > 99 & a < 1000)
{
    int lastNumber = a % 10;
    Console.WriteLine(lastNumber);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число, у которого нет третьей цифры");
}