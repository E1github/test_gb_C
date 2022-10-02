// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.



int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size]; 
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

int[] GetSumPstNgtElm(int[] array)
{
    int sumPstv = default;
    int sumNgt = default;

    for (int i = 0; i < array.Length; i++)
    {
       if (array[i]>0) sumPstv += array[i];
       else sumNgt += array[i]; 
    }

    return new int[]{sumPstv,sumNgt}; 
}


int GetSumPstElm(int[] array)
{
    int sumPstv = default;
    for (int i = 0; i < array.Length; i++)
           if (array[i]>0) sumPstv += array[i];
       
    return sumPstv; 
}

int GetSumNgtElm(int[] array)
{
    int sumNgt = default;
    for (int i = 0; i < array.Length; i++)
           if (array[i]<0) sumNgt += array[i];
       
    return sumNgt; 
}



int[] arr = CreateArrayRndInt(12,-9,9);
PrintArray(arr);

int sumPstv = GetSumPstElm(arr);
int sumNgt = GetSumNgtElm(arr);
Console.WriteLine($" [+]Z {sumPstv}, [-]Z {sumNgt}");