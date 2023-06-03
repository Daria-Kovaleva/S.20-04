// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 100);
PrintMatrix(array2d);
ReplaceMatrixElem(array2d);
Console.WriteLine();
PrintMatrix(array2d);

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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("| ");
    }
}

void ReplaceMatrixElem(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

