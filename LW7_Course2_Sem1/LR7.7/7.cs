Console.WriteLine("Введите последовательность чисел:");

List<int> numbers = new List<int>();
string input;

while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
{
    if (int.TryParse(input, out int number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
    }
}

numbers.Reverse();

Console.WriteLine("Числа в обратном порядке:");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}