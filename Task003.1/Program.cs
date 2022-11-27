// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели от 1 до 7:");

int a = int.Parse(Console.ReadLine());

while(a > 0 & a < 8)
{
    if(a > 0 & a < 6)
    {
        Console.WriteLine("Этот день рабочий");
        break;
    }
    else
    {
        Console.WriteLine("Этот день выходной");
        break;
    }
}
Console.WriteLine("Вы ввели неправильный порядковый номер");