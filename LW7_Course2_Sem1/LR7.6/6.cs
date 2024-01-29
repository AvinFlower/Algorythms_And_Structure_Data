Console.Write("Введите первое число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите второе число m: ");
int m = int.Parse(Console.ReadLine());

int gcd = FindGCD(n, m);
int lcm = (n * m) / gcd;

Console.WriteLine($"Наименьшее общее кратное ({n}, {m}) = {lcm}");

// Функция для нахождения НОД двух чисел
static int FindGCD(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}