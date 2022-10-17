// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array2D1 = CreateMatrixRndInt(3, 2, 1, 10);
int[,] array2D2 = CreateMatrixRndInt(2, 3, 1, 10);

Console.WriteLine("Первая матрица:");
PrintMatrix(array2D1);
Console.WriteLine("Вторая матрица:");
PrintMatrix(array2D2);
int[,] array2Dm = MultiplyMatrix(array2D1, array2D2);
Console.WriteLine("Матрица полученная в результате перемножения:");
PrintMatrix(array2Dm);


int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
              int sum = 0;
              for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }    

                matrix[i, j] = sum;
            }
        }
    }
    else
    {
        Console.WriteLine("Матрицы невозомжно перемножить.");
        return new int[1, 1];
    }
    return matrix;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}


