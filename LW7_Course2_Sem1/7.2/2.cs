int a = 48;
int b = 18;

int gcd = FindGCD(a, b);

Console.WriteLine($"Наибольший общий делитель ({a}, {b}) = {gcd}");
static int FindGCD(int a, int b)
{
    // Базовый случай: Если одно из чисел равно нулю, то НОД равен другому числу.
    if (a == 0) return b;
    if (b == 0) return a;

    // Рекурсивный случай: НОД находится путем вычитания меньшего числа из большего.
    if (a > b) return FindGCD(a - b, b);
    else return FindGCD(a, b - a);
}