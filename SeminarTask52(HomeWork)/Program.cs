// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(double[] matrix)
{   
    Console.Write("|");
    for (int j = 0; j < matrix.Length; j++)
    {       
        if (j < matrix.Length - 1) Console.Write($"{matrix[j], 4}| ");
            else Console.Write($"{matrix[j], 4}");

    }
    Console.Write("|");
}

double[] GetMiddleColMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {       
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            // else Console.Write($"{matrix[i, j],4} ");
        }
        result[i] = sum*1.0 / matrix.GetLength(0);
    }
    return result;
}

int[,] array2D = CreateMatrixRndInt(4, 8, 0, 10);

double[] arrayMid = GetMiddleColMatrix(array2D);

PrintMatrix(array2D);
Console.WriteLine("___________Средние значение по столбцу_________");
PrintArray(arrayMid);


