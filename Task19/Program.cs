// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999)
{
    bool palindrome = Palindrome(number);
    Console.Write(palindrome ? $"{number} -> да" : $"{number} -> нет");

    bool Palindrome(int num)
    {
        int firstDigit = num / 10000;
        int fifthDigit = num % 10;
        int secondDigit = (num / 1000) % 10;
        int fourthDigit = (num / 10) % 10;
        if (firstDigit == fifthDigit && secondDigit == fourthDigit)
        {
            return true;
        }
        return false;
    }
}
else Console.WriteLine("Неккоректный ввод! Введите пятизначное число");