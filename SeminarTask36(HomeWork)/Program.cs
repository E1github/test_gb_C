// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество чисел в массиве:");
int numCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество разрядов в числах массива:");
int numDigits = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = CreateArrayRndInt(numCount, InPow(10,numDigits-1), InPow(10,numDigits)-1);
// int[] arrayGlobal = {3, 7, 23, 12};
// int[] arrayGlobal = {-4, -6, 89, 6};
PrintArray(arrayGlobal);

// выводит сумму четных чисел в массиве
 Console.Write($" -> {SummOddElementsInArray(arrayGlobal)}");

//метод возведения в степень
int InPow(int num, int step)
{
    if (step == 1) return num;
    if (step == 0) return 1;
    int intC = 2;
    int numD = num;
    while (intC <= step)
    {
        numD = numD * num;
        intC++;
    }
    return numD;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

int SummOddElementsInArray(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
        result = result + array[i];
    return result;
}
