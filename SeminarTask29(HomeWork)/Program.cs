// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int numMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int numMax = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal, numMin, numMax);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array, int nMin, int nMax)
{
    Random rnd = new Random();
    for (int i = 0; i <= array.Length - 1; i++) array[i] = rnd.Next(nMin, nMax + 1);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

