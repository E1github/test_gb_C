// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите количество чисел в массиве:");
int numCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество разрядов целой части в числах массива:");
int numDigits = Convert.ToInt32(Console.ReadLine());

double[] arrayGlobal = CreateArrayRndReal(numCount, InPow(10,numDigits-1), InPow(10,numDigits)-1);
PrintArray(arrayGlobal);

// выводит разницу максимального и минимального чисел в массиве
  Console.Write($" -> {Math.Round((MaxElementInArray(arrayGlobal)-MinElementInArray(arrayGlobal)),2)}");

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

double[] CreateArrayRndReal(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}; ");
    Console.Write($"{array[array.Length - 1]}]");
}

double MinElementInArray(double[] array)
{
    double result = array[0];
        for (int i = 1; i < array.Length; i++)
            if (result > array[i]) result = array[i];
    return result;
}

double MaxElementInArray(double[] array)
{
    double result = array[0];
        for (int i = 1; i < array.Length; i++)
            if (result < array[i]) result = array[i];
    return result;
}