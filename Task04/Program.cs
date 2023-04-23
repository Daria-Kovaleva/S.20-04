// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите значение A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение C");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine($"{numberA}, {numberB}, {numberC} -> {max}");
