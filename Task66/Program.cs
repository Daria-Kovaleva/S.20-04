// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM == 0 || numberN == 0) Console.WriteLine("Введите числа больше 0!");
else
{
int sumElemInInterval = SumElemInInterval(numberM, numberN);
Console.WriteLine(sumElemInInterval);
}

int SumElemInInterval(int numM, int numN)
{
    if (numM == numN) return numM;
    else if (numM < numN) return numN + SumElemInInterval(numM, numN - 1);
    else return numN + SumElemInInterval(numM, numN + 1);
}