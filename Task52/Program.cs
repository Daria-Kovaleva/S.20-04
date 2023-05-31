// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("| ");
    }
}

double[] AverageColumns(int[,] matrix)
{
    double[] arr = new double [matrix.GetLength(1)];
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        double averageNum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            averageNum = sum / matrix.GetLength(0);
        }
        arr[j] = Math.Round(averageNum, 1);
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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

double[] average = AverageColumns(array2d);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArrayDouble(average, "; ");


