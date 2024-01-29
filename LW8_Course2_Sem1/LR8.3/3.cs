
int[] array = { 38, 27, 43, 3, 9, 82, 10 };

Console.WriteLine("Исходный массив:");
PrintArray(array);

MergeSort(array);

Console.WriteLine("Отсортированный массив:");
PrintArray(array);

Console.ReadKey();

static void MergeSort(int[] array)
{
    // Базовый случай: если массив содержит 1 элемент или меньше, он уже отсортирован.
    if (array.Length <= 1)
        return;

    // Находим средний индекс массива.
    int middle = array.Length / 2;

    // Создаем два подмассива, левый и правый, разделяя исходный массив по среднему индексу.
    int[] left = new int[middle];
    int[] right = new int[array.Length - middle];

    // Копируем элементы из исходного массива в подмассивы.
    Array.Copy(array, left, middle);
    Array.Copy(array, middle, right, 0, array.Length - middle);

    // Рекурсивно вызываем сортировку слиянием для левого и правого подмассивов.
    MergeSort(left);
    MergeSort(right);

    // Объединяем (сливаем) отсортированные левый и правый подмассивы обратно в исходный массив.
    Merge(array, left, right);
}

static void Merge(int[] result, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    // Пока не достигнут конец левого и правого подмассивов.
    while (i < left.Length && j < right.Length)
    {
        // Сравниваем элементы левого и правого подмассивов.
        // Меньший элемент помещаем в исходный массив и увеличиваем соответствующие индексы.
        if (left[i] < right[j])
            result[k++] = left[i++];
        else
            result[k++] = right[j++];
    }

    // Если в левом подмассиве остались элементы, добавляем их в результат.
    while (i < left.Length)
        result[k++] = left[i++];

    // Если в правом подмассиве остались элементы, добавляем их в результат.
    while (j < right.Length)
        result[k++] = right[j++];
}

static void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
