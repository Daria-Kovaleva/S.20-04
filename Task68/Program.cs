// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите целое положительное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM < 0) Console.WriteLine("Введите положительное число!");
else
{
int functionAckerman = FunctionAckerman(numberM, numberN);
Console.WriteLine($"A({numberM},{numberN}) = {functionAckerman}");
}

int FunctionAckerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return FunctionAckerman(numM - 1, 1);
    else return FunctionAckerman(numM - 1, FunctionAckerman(numM, numN - 1));
}