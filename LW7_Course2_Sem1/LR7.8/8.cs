int n = 20; // Здесь задайте значение n
int result = FindClosestFibonacci(n);
Console.WriteLine($"Максимальное число Фибоначчи, меньшее или равное {n}, равно {result}");
Console.ReadKey();

static int FindClosestFibonacci(int n, int a = 0, int b = 1)
{
    if (a <= n)
    {
        return FindClosestFibonacci(n, b, a + b);
    }
    else
    {
        return b;
    }
}
