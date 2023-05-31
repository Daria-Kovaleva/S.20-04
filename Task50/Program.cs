// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int rows = Promt("Введите индекс строки: ");
int columns = Promt("Введите индекс столбца: ");

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

if(rows < 0 && columns < 0) Console.WriteLine("Введите положительные значения!");

if (PositionElem(array2d, rows, columns)) Console.WriteLine($"{rows}, {columns} -> {array2d[rows, columns]}");
else  Console.WriteLine($"{rows}, {columns} -> такого элемента в массиве нет");

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

bool PositionElem(int[,] matrix, int row, int column)
{
    return row < matrix.GetLength(0) && column < matrix.GetLength(1) ? true : false;
}
