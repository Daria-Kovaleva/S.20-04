// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

//y = k1 * x + b1, 
//y = k2 * x + b2;

// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int k1 = Promt("Введите значение точки k1: ");
int b1 = Promt("Введите значение точки b1: ");
int k2 = Promt("Введите значение точки k2: ");
int b2 = Promt("Введите значение точки b2: ");

double x = FirstCoordinatePoint(k1, b1, k2, b2);
double y = SecondCoordinatePoint(k1, b1, k2, b2);

Console.WriteLine($"Точка пересечения между двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 -> ({x}, {y})");

double FirstCoordinatePoint(int numK1, int numB1, int numK2, int numB2)
{
    double first = numB2 - numB1;
    double second = numK1 - numK2;
    double third = first / second;
    double resX = Math.Round(third, 1);
    return resX;
}

double SecondCoordinatePoint(int numK1, int numB1, int numK2, int numB2)
{
    double coord2 = numK2 * x + numB2;
    double resY = Math.Round(coord2, 1);
    return resY;
}

int Promt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}