// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");

int x = int.Parse(Console.ReadLine()!);
int result;

if (x >= 100 && x < 1000)
{
    result = x % 100 / 10;
    Console.WriteLine($"Вторая цифра числа {x} -> {result} ");
}
else
{
    Console.WriteLine("Число не трёхзначное");
}