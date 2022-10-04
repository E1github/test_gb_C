// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// k1 * x + b1  = k2 * x + b2
// (k1-k2)x = b2-b1
// x = (b2-b1)/(k1-k2)

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэфициент b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэфициент k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэфициент b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэфициент k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

 double x = GetX(b1, k1, b2, k2);
 double y = k1 * x + b1;

Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");

double GetX(double bb1, double kk1, double bb2, double kk2)
{
    return (bb1 - bb2) / (kk2 - kk1);
}