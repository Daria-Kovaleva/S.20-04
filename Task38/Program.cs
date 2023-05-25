// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 1, 100);

double max = MaxElem(array);
double min = MinElem(array);

Console.Write("[");
PrintArrayDouble(array, ";");
Console.Write("]");

double difference = Diference(max, min);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива = {difference}");

double[] CreateArrayRndDouble(int size, int max, int min)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr, string sep)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}

double MaxElem(double [] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinElem(double [] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double Diference(double max, double min)
{
    max = MaxElem(array);
    min = MinElem(array);
    double diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}

