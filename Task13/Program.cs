// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int result = ThirdDigit(number);
    Console.WriteLine($"{number} -> {result}");

    bool result2 = DoubleDigits(number);

    int ThirdDigit(int num)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        return num % 10;
    }

    bool DoubleDigits(int num)
    {
        if (num < 100)
        {
            return false;
        }
        else return true;
    }
}
else Console.WriteLine($"{number} -> Третьей цифры нет");