// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

void FillEvenMatrixElements(int[,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i +=2 ) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j +=2) // 1 - columns
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
    
}

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
            else Console.Write($"{matrix[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}


int[,] array2D = CreateMatrixRndInt(7, 7, -10, 10);
PrintMatrix(array2D);
Console.WriteLine("");
FillEvenMatrixElements(array2D);
PrintMatrix(array2D);

