// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int square = SquareRec(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {square}");

int SquareRec(int a, int b)
{
    if (b == 0) return 1;
    return a * SquareRec(a, b-1);
}

// int SquareRec(int a, int b)
// {
//    return b == 0 ? 1 : a * SquareRec(a, b-1);
// }
