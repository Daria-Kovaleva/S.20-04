// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] array2d = CreateMatrixRndInt(4, 4, 0, 100);
PrintMatrix(array2d);
int[] minElemIndexs = MinElemIndexes(array2d);
Console.WriteLine(minElemIndexs[2]);
Console.WriteLine();
int[,] deleteRowColumn = DeleteRowColumn(array2d, minElemIndexs[0], minElemIndexs[1]);
PrintMatrix(deleteRowColumn);

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

int[] MinElemIndexes(int[,] matrix)
{
    int min = matrix[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) // < - по первому вхождению. <= - по последнему вхождению
            {
                min = matrix[i, j];
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column, min };
}

int[,] DeleteRowColumn(int[,] matrix, int delRow, int delColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == delRow) m++; // пропуск строки
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == delColumn) n++; // пропуск столбца
            newMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}