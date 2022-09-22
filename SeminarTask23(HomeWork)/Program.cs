// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int numX = Convert.ToInt32(Console.ReadLine());

if (numX > 0) TablePow3 (numX);
else Console.WriteLine("Введено число меньше 1"); 

void TablePow3 (int num)
{
    Console.WriteLine("===============");
    int counter = 1;
    while (counter <= num)
    {
        int counter3 = counter*counter*counter;
        Console.WriteLine($"|{counter,4} |  {counter3,4} |");
        counter++;
    }
    Console.WriteLine("===============");    
}



// string SrtingOfSqure (int num)
// {
//     return $"{num}   {num*num}";  
// }

// while (counter <= numX)
// {
//     Console.WriteLine(SrtingOfSqure(counter));
//     counter++;
// }