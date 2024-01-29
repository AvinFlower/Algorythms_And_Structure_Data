Console.Write("Введите номер числа Фибоначчи n: ");
int n = int.Parse(Console.ReadLine());

int result = CalculateFibonacci(n);

Console.WriteLine($"n-е число Фибоначчи: {result}");
static int CalculateFibonacci(int n)
{
    // Базовые случаи: первые два числа Фибоначчи равны 1.
    if (n == 1 || n == 2)
        return 1;

    // Рекурсивный случай: an = an-1 + an-2
    int fibNMinus1 = CalculateFibonacci(n - 1);
    int fibNMinus2 = CalculateFibonacci(n - 2);
    return fibNMinus1 + fibNMinus2;
}