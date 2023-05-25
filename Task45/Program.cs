// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}


int[] oldArray = CreateArrayRndInt(5, 10, 20);
Console.Write("[");
PrintArray(oldArray);
Console.Write("]");

Console.WriteLine();

int[] newArray = CopyArray(oldArray);
Console.Write("[");
PrintArray(newArray);
Console.Write("]");