// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB <= 0) Console.WriteLine("Введено не натуральное число B! Введите натуральое число B");
else
{
    int degree = DegreeNumbers(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} -> {degree}");
}

int DegreeNumbers(int numA, int numB)
{
    int deg = 1;
    for (int i = 0; i < numB; i++)
    {
        deg = deg * numA;
    }
    return deg;
}