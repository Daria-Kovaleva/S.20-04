// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = CreateMatrixRndInt1(2, 2, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();

int[,] matrix2 = CreateMatrixRndInt2(2, 2, 1, 9);
PrintMatrix(matrix2);
Console.WriteLine();

Console.WriteLine("Результирующая матрица:");
int[,] productOfMatrices = ProductOfMatrices(matrix1, matrix2);
PrintMatrix(productOfMatrices);




int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)
{
    int[,] matrA = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrA.GetLength(1); j++)
        {
            matrA[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrA;
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrB = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrB.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            matrB[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrB;
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

int[,] ProductOfMatrices(int[,] matrA, int[,] matrB)
{
    int[,] newMatrix = new int[matrA.GetLength(0), matrB.GetLength(1)];

    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                newMatrix[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return newMatrix;
}