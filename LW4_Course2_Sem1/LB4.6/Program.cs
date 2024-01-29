int[,] M = new int[4, 5];
int maxMatrix = 0;
Random random = new Random();

Console.WriteLine("Матрица M:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        M[i, j] = random.Next(1, 14);

        if (M[i, j] > maxMatrix) maxMatrix = M[i, j];

        Console.Write(M[i, j] + " ");
    }
    Console.WriteLine();
}

int[] B = new int[10];

Console.WriteLine("\nМассив B:");
if (maxMatrix > 12)
{
    for (int i = 0; i < B.Length; i++)
    {
        B[i] = random.Next(0, 10);
    }

    Array.Sort(B);
    Array.Reverse(B);

    foreach (int num in B)
    {
        Console.Write(num + " ");
    }
}
else
{
    for (int i = 0; i < B.Length; i++)
    {
        B[i] = random.Next(0, 10);
        Console.Write(B[i] + " ");
    }
}
Console.ReadKey();