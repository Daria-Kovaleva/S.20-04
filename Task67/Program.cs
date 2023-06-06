// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number} = {SumRec(number)}");

int SumRec(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumRec(n / 10);
}

