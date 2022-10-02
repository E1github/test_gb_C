// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите количество чисел в массиве:");
int numCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите разрядов в числах массива:");
int numDigits = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = CreateArrayRndInt(numCount, InPow(10,numDigits-1), InPow(10,numDigits)-1);
// int[] arrayGlobal = {345, 897, 568, 234};
PrintArray(arrayGlobal);

// выводит количетство четных чисел в массиве
 Console.Write($" -> {CountEvenNumInArray(arrayGlobal)}");

// выводит количетство четных ЦИФР в числах массива
// Console.Write($" -> {CountEvenDigitsInArray(arrayGlobal)}");

//можно было просто удалить данную функцию, но она была написана из-за не верно воспринятого задания -
// подсчиать количество четных ЦИФР в трехзначных числах массива, все оказалось гораздо проще-))
// и она работает. Мне кажется для тестовго задания можно оставить оба варианта...
int CountEvenDigitsInNum(int num)
{
    int sum = 0;
    int digit = default;
    int countDigits = CountDigits(num);
    for (int i = 1; i <= countDigits; i++) 
        {
        digit = (num / InPow(10, countDigits - i)) % 10;
        if (digit % 2 == 0 ) sum++;
        }
    return sum;
}

int CountDigits(int num)
{
    int counter = 0;
    while (num != 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}

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

int CountEvenDigitsInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        result = result + CountEvenDigitsInNum(array[i]);
    return result;
}

int CountEvenNumInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
            result++;
    }
    return result;
}
