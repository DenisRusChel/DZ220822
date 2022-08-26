// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

    if (num < 1 || num> 7)
    {
        System.Console.WriteLine("Введите число от 1 до 7");
    }
    if (num == 6 ||num == 7 )
    {
        System.Console.WriteLine($"{num} → да");
    }

    else
    {
        System.Console.WriteLine($"{num} → нет");
    }