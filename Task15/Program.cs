// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
int days = Convert.ToInt32(Console.ReadLine());

bool result = Weekends(days);

bool result2 = NotWeek(days);

bool Weekends(int day)
{
    if (day > 5 & day <= 7)
    {
        Console.WriteLine("да");
        return true;
    }
    else if (day <= 5)
    {
        Console.WriteLine("нет");
        return true;
    }
    return false;
}

bool NotWeek(int day)
{
    if (day > 7)
    {
        Console.WriteLine("Введите корректное число от 1 до 7");
        return true;
    }
    return false;
}

