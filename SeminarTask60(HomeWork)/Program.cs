// адача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

void FillCubeInt(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
        for (int j = 0; j < cube.GetLength(1); j++)
            for (int k = 0; k < cube.GetLength(2); k++)
                cube[i, j, k] = (i + 1) * 20 + (j + 1) * 10 + k;

}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
        for (int j = 0; j < cube.GetLength(1); j++)
            for (int k = 0; k < cube.GetLength(2); k++)
                if (k < cube.GetLength(2) - 1) Console.Write($"{cube[i, j, k]}({i},{j},{k})  ");
                else Console.WriteLine($"{cube[i, j, k]}({i},{j},{k})");
}

int[,,] array3D = new int[2, 2, 2];

FillCubeInt(array3D);
PrintCube(array3D);