// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

string binary = BinaryNumber(number);
Console.WriteLine($"{number} -> {binary}");

string BinaryNumber(int num)
{
    string count = string.Empty; //пустая строка
    while (num >= 1)
    {
        count = (num % 2) + count;
        num = num / 2;
    }
    return count;
}


