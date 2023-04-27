// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// метод для извлечения корня
// double d = Math.Sqrt(5);

// double num = 5.099786232;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);

// метод возведения в квадрат
// double pw = Math.Pow(3, 6);

Console.WriteLine("Введите координаты A(x1, y1)");
Console.Write("X1: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты B(x2, y2)");
Console.Write("X2: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double yB = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xA, yA, xB, yB);
double round = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine(round);


double Distance(double x1, double y1, double x2, double y2)
{
    double sumCathet = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
    double distance = Math.Sqrt(sumCathet);
    return distance;
}