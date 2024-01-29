//№1

Console.WriteLine("№1");
int[] X = new int[10];
Random random = new Random();

Console.WriteLine("Массив рандомных чисел от 1 до 99:");
for (int i = 0; i < X.Length; i++)
{
    X[i] = random.Next(1, 100);
    Console.Write(X[i] + " ");
}
Console.WriteLine("\nМаксимальный элемент массива: " + X.Max());
// Сложность N = 12


//№2

Console.WriteLine("\n№2");
int[] A = new int[20];
int[] B = new int[20];
int[] C = new int[20];

Console.WriteLine("Генерируем массив A:");
for (int i = 0; i < A.Length; i++)
{
    A[i] = random.Next(1, 100);
    Console.Write(A[i] + " ");
}

Console.WriteLine("\nГенерируем массив B:");
for (int i = 0; i < B.Length; i++)
{
    B[i] = random.Next(1, 100);
    Console.Write(B[i] + " ");
}

if (A.Max() > B.Max()) Console.Write("\nМаксимальный элемент из массивов A и B: " + A.Max());
else Console.Write("\nМаксимальный элемент из массивов A и B: " + B.Max());

Console.WriteLine("\nИтоговый массив C:");
for (int i = 0; i < C.Length; i++)
{
    if (A.Max() > B.Max())
    {
        C[i] = A.Max();
        Console.Write(C[i] + " ");
    }
    else
    {
        C[i] = B.Max();
        Console.Write(C[i] + " ");
    }
}
//Сложность N = 63

Console.ReadKey();
