Console.Write("Введите первое число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число c: ");
int c = int.Parse(Console.ReadLine());

int gcdAB = FindGCD(a, b); // Находим НОД для первых двух чисел
int gcdABC = FindGCD(gcdAB, c); // Находим НОД для всех трех чисел

Console.WriteLine($"Наибольший общий делитель ({a}, {b}, {c}) = {gcdABC}");

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