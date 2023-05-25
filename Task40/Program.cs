// Напишите программу, которая принимает на вход три числа
// И проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Введите сторону a: ");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
int sideC = Convert.ToInt32(Console.ReadLine());


bool result = TheTriangleInequalityTheorem(sideA, sideB, sideC);
Console.WriteLine (result ? $"Да это треугольник!" : "Это не треугольник");

bool TheTriangleInequalityTheorem(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < a + b) return true;
    else return false;
}
