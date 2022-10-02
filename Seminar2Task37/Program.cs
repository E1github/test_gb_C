// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] MultipleArrayElements(int[] array)
{
    int lengthNewArray = array.Length / 2;
    if (array.Length % 2 != 0)
         lengthNewArray++;

    int[] result = new int[lengthNewArray];

    for (int i = 0; i < lengthNewArray; i++)
    {
       result[i] = array[i] * array[array.Length-i-1]; 
    }

    if (array.Length % 2 != 0)
         result[lengthNewArray-1] = array[array.Length / 2 ];

    return result;
}
// array1[i] = rnd.NextDouble() * (max - min) + min;


int[] arrayGlobal = CreateArrayRndInt(7, 5, 10);
PrintArray(arrayGlobal);
int[] arrayNew = MultipleArrayElements(arrayGlobal);
PrintArray(arrayNew);