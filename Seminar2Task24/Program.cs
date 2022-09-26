// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Write("Введите число от 1 и больше: ");
int numX = Convert.ToInt32(Console.ReadLine());

int Summ1N (int num)
{
int sum = default;
    for (int i =1; i <= num; i++ )
    {
        sum = sum +1;
    }
return sum;
}