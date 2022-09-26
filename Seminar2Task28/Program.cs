// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Write("Введите число от 1 и больше: ");
int numX = Convert.ToInt32(Console.ReadLine());

int Factorial (int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++ )
    {
        fact = fact * i;
    }
return fact;
}

Console.Write (Factorial(numX));