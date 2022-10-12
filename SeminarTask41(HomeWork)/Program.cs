// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Write("Input nums (use space to sepparate): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// Console.WriteLine($"Count of nums > 0 -> {count}");


Console.Write("Введите количество чисел: ");
int numA = Convert.ToInt32(Console.ReadLine());

int count = 0;
//если бы не нужен был вывод вводимых чисел, то можно было бы обойтись без массива
int[] array = new int[numA];

FillArrayFromConsoleCountPositive(numA);
PrintArray(array);

Console.Write($"-> {count} ");

void FillArrayFromConsoleCountPositive(int num)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
}

void PrintArray(int[] array)
{
    
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]} ");
}

