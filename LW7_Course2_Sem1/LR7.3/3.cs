Console.Write("Введите первый член a1: ");
int a1 = int.Parse(Console.ReadLine());

Console.Write("Введите разность d: ");
int d = int.Parse(Console.ReadLine());

Console.Write("Введите номер члена n: ");
int n = int.Parse(Console.ReadLine());

int result = CalculateArithmeticProgression(a1, d, n);

Console.WriteLine($"n-й член арифметической прогрессии: {result}");
static int CalculateArithmeticProgression(int a1, int d, int n)
{
    // Базовый случай: n=1, возвращаем a1
    if (n == 1) return a1;

    // Рекурсивный случай: an = an-1 + d
    int anMinus1 = CalculateArithmeticProgression(a1, d, n - 1);
    return anMinus1 + d;
}