int n = 49; // Общее количество чисел
int k = 6;  // Количество чисел, которые нужно выбрать

long ways = BinomialCoefficient(n, k);

Console.WriteLine($"Способы выбрать {k} чисел из {n} равны {ways}");

static long BinomialCoefficient(int n, int k)
{
    if (k == 0 || k == n) return 1;
    return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
}
