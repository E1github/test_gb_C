// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] GetArrayFromMatrix(int[,] matrix)
{
    int[] result = new int[matrix.Length];

    int index = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[index] = matrix[i, j];
            index++;
        }

    }
    return result;
}

void CountNPrintArrayGlossary(int[] localarray)
{
    int num = localarray[0];
    int counter = 1;
    for (int i = 1; i < localarray.Length; i++)
    {
        if (num == localarray[i])
        {
            counter++;
        }
        else
        {
            Console.WriteLine($"{num} повторяется {counter} раз");
            num = localarray[i];
            counter = 1;
        }
    }
Console.WriteLine($"{num} повторяется {counter} раз");

}

void PintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine($"]");
}




int[,] array2D = CreateMatrixRndInt(5, 5, 0, 10);
int[] array = GetArrayFromMatrix(array2D);
Array.Sort(array);
PrintMatrix(array2D);
PintArray(array);
CountNPrintArrayGlossary(array);



