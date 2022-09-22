// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число от 1 и больше: ");
int numX = Convert.ToInt32(Console.ReadLine());

if (numX > 0) TablePow3 (numX);
else Console.WriteLine("Введено число меньше 1"); 

void TablePow3 (int num)
{
    Console.WriteLine("===============");
    int counter = 1;
    while (counter <= num)
    {     
        Console.WriteLine($"|{counter,4} |  {counter*counter*counter,4} |");
        counter++;
    }
    Console.WriteLine("===============");    
}
