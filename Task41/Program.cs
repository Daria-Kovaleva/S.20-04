// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArrayForCount(int count)
{
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Promt($"Введите число {i + 1}: ");
    }
    return arr;
}

void PrintArray(int[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int CountPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

int numM = Promt("Введите число элементов: ");

int[] array = CreateArrayForCount(numM);
PrintArray(array, ", ");

int countNum = CountPositiveNum(array);
Console.WriteLine($" -> {countNum}");