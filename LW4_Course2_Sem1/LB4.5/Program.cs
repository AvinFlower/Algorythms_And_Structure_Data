//№5

int[] X = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Массив X: 1 2 3 4 5 6 7 8 9 10");
int[] Y = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
Console.WriteLine("Массив Y: 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25");
int[,] A = new int[5, 5];

int xIndex = 0, yIndex = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (i + j >= 4)
        {
            A[i, j] = Y[yIndex];
            yIndex++;
        }
        else
        {
            A[i, j] = X[xIndex];
            xIndex++;
        }
    }
}

// вывод матрицы A
Console.WriteLine("\nМассив A:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{A[i, j]} ");
    }
    Console.WriteLine();
}

Console.ReadKey();