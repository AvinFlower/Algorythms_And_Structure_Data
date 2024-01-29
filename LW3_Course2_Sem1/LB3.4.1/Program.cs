double a = 0, S = 0, fact = 1, x = 1, n = 1;

Console.Write("Введите целое значение V: ");
int V = Convert.ToInt32(Console.ReadLine());

do
{
    for (int i = 1; i <= n; i++)
    {
        fact = fact * (i + 1);
    }
    a = 2 * n * x / fact;
    S += a;
    Console.WriteLine($"Если x = {x} и n = {n}, то S = {S}, a = {a}");
    x++;
    n++;
    if (x == 27) break;
}
while (S <= V);
Console.Write($"Сумма теперь больше V, последний элемент: {a}");
Console.ReadKey();