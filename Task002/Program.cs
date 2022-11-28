// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число от 10 до 999:");

int a = int.Parse(Console.ReadLine());

int count = 0;
if (a > 99)
{
    while (a > 999)
    {
        count = a / 10;
        a = count;    
    }
    int result = a % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("У вашего числа нет третьей цифры");
}