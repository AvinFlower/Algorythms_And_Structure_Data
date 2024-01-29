//№3
Console.WriteLine("№3");
int[] X = new int[14];
Random random = new Random();

Console.WriteLine("Массив рандомных чисел от 1 до 4, в котором все числа, сгенерировавшиеся < 2 становятся нулями:");
for (int i = 0; i < X.Length; i++)
{
    X[i] = random.Next(1, 5);
    if (X[i] < 2) X[i] = 0;
    Console.Write(X[i] + " ");
}


//№4
Console.WriteLine("\n\n№4");
int[,] Z = new int[6, 6];
int m = 0, n = 0, maxNum = 0, multiply = 1;
Console.WriteLine("Матрица:");
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Z[i, j] = random.Next(-10, 10);
        if (Z[i, j] == Z[m, n] && Z[i, j] > maxNum)
        {
            maxNum = Z[i, j];
        }
        if (Z[i, j] < 0) multiply *= Z[i, j];
        Console.Write(Z[i, j] + " ");
        if (j == 5) Console.WriteLine();
    }
    m++;
    n++;
}
Console.WriteLine($"Максимальный элемент на главной диагонали: {maxNum}\nПроизведение отрицательных чисел: {multiply}");
Console.ReadKey();