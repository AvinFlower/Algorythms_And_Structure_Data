Console.Write("Введите строку: ");
string input = Console.ReadLine();

int i = 0; // Начальный индекс фрагмента
int j = input.Length - 1; // Конечный индекс фрагмента

bool isPalindrome = IsPalindrome(input, i, j);

if (isPalindrome)
{
    Console.WriteLine($"Фрагмент строки с {i}-го по {j}-ый символ является палиндромом.");
}
else
{
    Console.WriteLine($"Фрагмент строки с {i}-го по {j}-ый символ не является палиндромом.");
}
static bool IsPalindrome(string str, int i, int j)
{
    if (i >= j)
    {
        // Базовый случай: если i больше или равно j, это палиндром.
        return true;
    }

    if (str[i] != str[j])
    {
        // Если символы на i и j позициях не совпадают, это не палиндром.
        return false;
    }

    // Рекурсивно проверяем внутренний фрагмент строки.
    return IsPalindrome(str, i + 1, j - 1);
}