// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] patternForMatrix =
        new int[16, 2] { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { 1, 3 }, { 2, 3 }, { 3, 3 }, { 3, 2 }, 
                            { 3, 1 }, { 3, 0 }, { 2, 0 }, { 1, 0 }, { 1, 1 }, { 1, 2 }, { 2, 2 }, { 2, 1 } };

void FillMatrixByPattern(int[,] matrix, int[,] pat)
{
    for (int i = 0; i < pat.GetLength(0); i++)
        matrix[pat[i, 0], pat[i, 1]] = i + 1;
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


int[,] array2D = new int[4,4];

FillMatrixByPattern(array2D, patternForMatrix);

PrintMatrix(array2D);