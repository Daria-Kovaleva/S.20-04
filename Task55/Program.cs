// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int rows = 3;
int columns = 3;
if (rows != columns)
{
    Console.WriteLine("Замена строк столбцами невозможна!");
    return;
}

int[,] array2d = CreateMatrixRndInt(rows, columns, 0, 100);
PrintMatrix(array2d);
Replace(array2d);
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

void Replace(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <  i; j++)
        {

            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;

        }
    }
}

// int[,] ChangeRowsWithColumns (int[,] matrix)
// {
//     int[,] newmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++) // rows = arr.GetLength (0)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++) // columns = arr.GetLength (1)
//         {
//             newmatrix[i, j] = matrix[j,i]; // [1;10)]
//         }
//     }
//     return newmatrix;
// }

// int[,] array2d = CreateMatrixRndInt(rrows, ccolumns, minimum, maximum);
// PrintMatrix(array2d);
// Console.WriteLine(); //разделяем новый и старый массив пустой строкой

// if (rrows != ccolumns) 
// {
//     Console.WriteLine ("Замена строк столбцами невозможна");
//     return;
// }

// int [,] newarray2d = ChangeRowsWithColumns (array2d);
// PrintMatrix(newarray2d);
