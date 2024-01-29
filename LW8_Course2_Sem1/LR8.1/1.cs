int[] array = { 3, 6, 8, 10, 1, 2, 1 };

Console.WriteLine("Исходный массив:");
PrintArray(array);

// Запускаем алгоритм быстрой сортировки
QuickSortAlgorithm(array, 0, array.Length - 1);

Console.WriteLine("\nОтсортированный массив:");
PrintArray(array);

// Определение алгоритма быстрой сортировки
static void QuickSortAlgorithm(int[] arr, int low, int high)
{
    if (low < high)
    {
        // Выбираем опорный элемент (pivot) и получаем его индекс
        int pivotIndex = Partition(arr, low, high);

        // Рекурсивно сортируем элементы слева
        QuickSortAlgorithm(arr, low, pivotIndex - 1);

        // Рекурсивно сортируем элементы справа
        QuickSortAlgorithm(arr, pivotIndex + 1, high);
    }
}

static int Partition(int[] arr, int low, int high)
{
    // Задаем опорный элемент
    int pivot = arr[high];
    // Инициализируем индекс меньших элементов
    int i = low - 1;

    // Перебираем элементы массива
    for (int j = low; j < high; j++)
    {
        if (arr[j] <= pivot)
        {
            // Если текущий элемент меньше или равен опорному, увеличиваем индекс меньших элементов и меняем местами элементы
            i++;
            Swap(arr, i, j);
        }
    }

    // Меняем местами опорный элемент и элемент, следующий за меньшими элементами
    Swap(arr, i + 1, high);
    // Возвращаем индекс опорного элемента
    return i + 1;
}

static void Swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

static void PrintArray(int[] arr)
{
    foreach (var num in arr)
    {
        Console.Write(num + " ");
    }
}
