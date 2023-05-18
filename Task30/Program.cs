// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];

// int[] array0 = new int[] { 3, 6, 8, 8, 7 };
// int[] array01 = new int[5] { 3, 6, 8, 8, 7 };
// int[] array1 = { 1, 4, 7, 8 };

// var array2 = new int[8]; // 0, 1, 2, 3, 4, 5, 6, 7
// array2[5] = 45;
// array2[0] = 4;

int[] array = new int[8];

FillArray(array);
Console.Write("[ ");
SeeArray(array);
Console.Write("]");
Console.WriteLine("\n");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void SeeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else  Console.Write(array[i] + " ");
    }
}