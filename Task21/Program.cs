// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты A(x1, y1, z1)");
Console.Write("X1: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты B(x2, y2, z2)");
Console.Write("X2: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
double zB = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xA, yA, zA, xB, yB, zB);
double round = Math.Round(dist, 2);
Console.WriteLine(round);


double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double sumCathet = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2);
    double distance = Math.Sqrt(sumCathet);
    return distance;
}