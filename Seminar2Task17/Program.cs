Console.Write("Введите первое число: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numY = Convert.ToInt32(Console.ReadLine());

int quarter = InArea (numX, numY);
string result = quarter > 0 ? $"указанные координаты соотвествуют четверти -> {quarter.ToString}" : "ввелены некорретные данные";

Console.WriteLine(result);

int InArea (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x > 0 && y < 0) return 4;
    if (x < 0 && y < 0) return 3;
    if (x < 0 && y > 0) return 2;
    return 0;
}

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter (x, y);
// string result = quarter > 0 ? $"Указанные координаты соответствуют четверти -> {quarter.ToString()}" 
//                             : "Введены некорректные координаты";
// Console.WriteLine(result);

// int Quarter (int xc, int yc)
// {
//     if(xc > 0 && yc > 0) return 1;
//     if(xc < 0 && yc > 0) return 2;
//     if(xc < 0 && yc < 0) return 3;
//     if(xc > 0 && yc < 0) return 4;
//     return 0;
// }
