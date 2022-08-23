//  Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите 3-х значное число: ");
int num = int.Parse(Console.ReadLine());

int secondDigit =  num / 10 % 10; 

System.Console.WriteLine($"{num} → {secondDigit}");