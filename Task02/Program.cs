// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите значение A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
int min = numberB;
if (numberB > max) max = numberB;
{
    Console.WriteLine($"max = {max}");
}
if (numberA < min) min = numberA;
{
    Console.WriteLine($"min = {min}");
}