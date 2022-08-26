// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    System.Console.WriteLine($"{num} → Третьей цыфры нет");
}

int number = 0;
while (num > 999)
{
    num = num / 10;
    number = num % 10;
}


System.Console.WriteLine(number);

















































