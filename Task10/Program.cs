// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);

if (number < 0) number *= -1;
if (number >= 100 && number <= 999) Console.WriteLine($"{result}");

else
{
    Console.WriteLine("Неккорктный ввод!! Введите трехзначное число ");
}

int SecondDigit(int num)
{
    return num = num / 10 % 10;
}
