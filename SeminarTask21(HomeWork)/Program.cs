// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int numAX = Convert.ToInt32(Console.ReadLine());
Console.Write(" Y: ");
int numAY = Convert.ToInt32(Console.ReadLine());
Console.Write("  Z: ");
int numAZ = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int numBX = Convert.ToInt32(Console.ReadLine());
Console.Write(" Y: ");
int numBY = Convert.ToInt32(Console.ReadLine());
Console.Write("  Z: ");
int numBZ = Convert.ToInt32(Console.ReadLine());

double LenghtLine3D (int ax, int ay,int az, int bx, int by, int bz)
{
    if (ay == by && ax == bx && az == bz) return 0;
    int x = bx - ax;
    int y = by - ay;
    int z = bz - az;
    return Math.Sqrt(x*x + y*y + z*z);
}

double lenghtAB = LenghtLine3D(numAX,numAY,numAZ,numBX,numBY,numBZ);
double lenght = Math.Round(lenghtAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({numAX},{numAY},{numAZ}); B ({numBX}, {numBY}, {numBZ}) -> {lenght}");