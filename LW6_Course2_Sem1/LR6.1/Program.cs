//№1---------------------------------------------------------------------------------
Console.WriteLine("№1");

int[] array1 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
int[] array11 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
int[] array111 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
string result0 = string.Join(", ", array1);
Console.WriteLine("Неотсортированный массив: " + result0);

//Вывод выбором
SelectionSort(array1);
string result1 = string.Join(", ", array1);
Console.WriteLine("Вывод выбором: " + result1);

//Вывод пузырьком
BubbleSort(array11);
string result11 = string.Join(", ", array11);
Console.WriteLine("Вывод пузырьком: " + result11);

//Вывод вставкой
InsertionSort(array111);
string result111 = string.Join(", ", array111);
Console.WriteLine("Вывод вставкой: " + result111);

//Сортировка выбором
void SelectionSort(int[] arr)
{
    int n = arr.Length;
    int count = 3;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        count+=2;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
                count++;
            }
            count+=2;
        }
        // Обмен элементов
        int temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
        count += 3;
    }
    Console.WriteLine("\nКоличество операций сравнения + присваивания методом выбора = " + count);
}

//Сортировка пузырьком
void BubbleSort(int[] arr)
{
    int n = arr.Length;
    int count = 3;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                // Обмен элементов
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                count += 3;
            }
            count += 2;
        }
        count++;
    }
    Console.WriteLine("Количество операций сравнения + присваивания методом пузырька = " + count);
}

//Сортировка вставкой
void InsertionSort(int[] arr)
{
    int n = arr.Length;
    int count = 2;
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;
        count+= 2;
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j--;
            count+= 4;
        }
        arr[j + 1] = key;
        count+= 1;
    }
    Console.WriteLine("Количество операций сравнения + присваивания методом вставки = " + count);
}


//№2---------------------------------------------------------------------------------

Console.WriteLine("\n№2");
int[] array2 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
//Вывод змейков
SnakeSortAlgorithm(array2);
string result2 = string.Join(", ", array2);
Console.WriteLine("\nВывод змейкой: " + result2);
//Сортировка массива змейкой
static void SnakeSortAlgorithm(int[] arr)
{
    int n = arr.Length;
    bool forward = true;

    for (int i = 0; i < n - 1; i++)
    {
        if (forward)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        else
        {
            for (int j = n - 1; j > 0; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
        forward = !forward;
    }
}

//№3---------------------------------------------------------------------------------

Console.WriteLine("\n№3");
int[] array3 = { 64, 34, 25, 12, 22};

//Вывод вставкой
InsertionSortChanged(array3);
string result3 = string.Join(", ", array3);
Console.WriteLine("Вывод вставкой элементов на четных местах: " + result3);

//Сортировка вставкой
void InsertionSortChanged(int[] arr)
{
    int n = arr.Length; // Длина массива

    // Начинаем цикл с индекса 1, используя шаг 2 для альтернативных элементов
    for (int i = 1; i < n; i += 2)
    {
        int key = arr[i]; // Запоминаем текущий элемент

        int j = i - 2; // Инициализируем индекс для сравнения с предыдущими элементами

        // Пока не достигнут начало массива и предыдущий элемент больше key
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 2] = arr[j]; // Сдвигаем элемент вправо на 2 позиции
            j -= 2; // Двигаемся к предыдущим элементам с шагом 2
        }

        arr[j + 2] = key; // Вставляем key в правильную позицию в отсортированной части массива
    }
}

//№4---------------------------------------------------------------------------------

Console.WriteLine("\n№4");
int[] array4 = { 1, 3, 2, 5, 7, 9, 10 };

//Вывод пузырьком
BubbleSortChanged(array4);
string result4 = string.Join(", ", array4);
Console.WriteLine("Вывод пузырьком с исключением лишних просмотров: " + result4);
//Сортировка пузырьком
void BubbleSortChanged(int[] arr)
{
    int n = arr.Length; // Длина массива
    bool swapped; // Флаг для отслеживания перестановок
    int count = 0; // Счетчик итераций

    // Внешний цикл проходит по элементам массива
    for (int i = 0; i < n - 1; i++)
    {
        swapped = false; // Сброс флага перестановок перед каждой итерацией

        // Внутренний цикл для сравнения и перестановки элементов
        for (int j = 0; j < n - i - 1; j++)
        {
            // Если текущий элемент больше следующего, производим обмен
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
                swapped = true; // Устанавливаем флаг перестановки
            }
        }

        count += 1; // Увеличиваем счетчик итераций
        Console.WriteLine("Количество итераций по обмену: " + count);

        // Если не было перестановок на данной итерации, массив уже отсортирован
        if (!swapped)
            break;
    }
}

//№5---------------------------------------------------------------------------------

Console.WriteLine("\n№5");
int[] array5 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
//Вывод сменой направлений
BubbleSortAlgorithm(array5);
string result5 = string.Join(", ", array5);
Console.WriteLine("Вывод массива сменой направлений: " + result5);
//Сортировка массива сменой направлений
static void BubbleSortAlgorithm(int[] arr)
{
    int n = arr.Length;  // Получаем длину массива
    bool forward = true; // Флаг, который указывает направление сортировки (true - прямое, false - обратное)

    for (int i = 0; i < n - 1; i++)  // Внешний цикл для прохода по всем элементам массива
    {
        if (forward)  // Если флаг прямой сортировки
        {
            for (int j = 0; j < n - 1; j++)  // Внутренний цикл для прямой сортировки
            {
                if (arr[j] > arr[j + 1])  // Если текущий элемент больше следующего
                {
                    int temp = arr[j];   // Обмен значениями элементов
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        else  // Если флаг обратной сортировки
        {
            for (int j = n - 1; j > 0; j--)  // Внутренний цикл для обратной сортировки
            {
                if (arr[j] < arr[j - 1])  // Если текущий элемент меньше предыдущего
                {
                    int temp = arr[j];   // Обмен значениями элементов
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
        forward = !forward;  // Изменение направления сортировки после каждой итерации
    }
}


//№6---------------------------------------------------------------------------------

Console.WriteLine("\n№6");
int[] array6 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
//Вывод сменой направлений
ShakerSort(array6);
string result6 = string.Join(", ", array6);
Console.WriteLine("Вывод шейкер-сортировкой: " + result6);
//Сортировка массива сменой направлений
static void ShakerSort(int[] arr)
{
    int n = arr.Length;
    bool swapped = true;
    int start = 0;
    int end = n - 1;

    while (swapped)
    {
        swapped = false;

        // проход слева направо
        for (int i = start; i < end; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }

        if (!swapped) break;// если не было обмена на прошлой итерации, массив уже отсортирован

        swapped = false;

        end--;// уменьшаем диапазон для следующего прохода

        // проход справа налево
        for (int i = end - 1; i >= start; i--)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }

        start++; // увеличиваем диапазон для следующего прохода
    }
}


//№7---------------------------------------------------------------------------------

Console.WriteLine("\n№7");
int[] array7 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
//Вывод сменой направлений
InsertionSortWhile(array7);
string result7 = string.Join(", ", array7);
Console.WriteLine("Вывод вставкой while: " + result7);
//Сортировка массива сменой направлений
static void InsertionSortWhile(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int j = i - 1;

        // Сдвигаем элементы больше key вправо
        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}


//№8---------------------------------------------------------------------------------

Console.WriteLine("\n№8");
int[] array8 = { 64, 34, 25, 12, 22, 11, 90, 45, 9, 72 };
//Вывод сменой направлений
BinaryInsertionSort(array8);
string result8 = string.Join(", ", array8);
Console.WriteLine("Вывод бинарными вставками: " + result8);
//Сортировка массива сменой направлений
static void BinaryInsertionSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 1; i < n; i++)
    {
        int key = arr[i];
        int left = 0;
        int right = i - 1;

        // Используем бинарный поиск для нахождения места вставки элемента
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (key < arr[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        // Сдвигаем элементы, чтобы освободить место для вставки
        for (int j = i - 1; j >= left; j--)
        {
            arr[j + 1] = arr[j];
        }

        arr[left] = key; // Вставляем элемент на найденное место
    }
}


//№9---------------------------------------------------------------------------------

Console.WriteLine("\n№9");
int[] array9 = { 9, 5, 2, 8, 1, 7, 3, 6, 4 };
int[] increments9 = { 7, 6, 5, 4, 3, 2, 1 };
//Вывод сменой направлений
ShellSort(array9, increments9);
string result9 = string.Join(", ", array9);
Console.WriteLine("Вывод с убывающим шагом: " + result9);
//Сортировка массива сменой направлений
static void ShellSort(int[] arr, int[] increments)
{
    // Перебираем все значения инкремента из переданного массива инкрементов
    foreach (int increment in increments)
    {
        // Начинаем с элемента, находящегося на расстоянии инкремента от начала массива
        for (int i = increment; i < arr.Length; i++)
        {
            int temp = arr[i]; // Запоминаем текущий элемент
            int j = i;

            // Пока не достигнем начала массива и предыдущий элемент больше текущего
            while (j >= increment && arr[j - increment] > temp)
            {
                // Сдвигаем элементы вправо на расстояние инкремента
                arr[j] = arr[j - increment];
                j -= increment;
            }

            arr[j] = temp;// Вставляем сохраненное значение на правильное место в текущем подмассиве
        }
    }
}


//№10---------------------------------------------------------------------------------

Console.WriteLine("\n№10");
int[] array10 = { 7, 10, 3, 5, 15, 9, 6, 12, 8 };
//Вывод сменой направлений
QuadraticSelectionSort(array10);
string result10 = string.Join(", ", array10);
Console.WriteLine("Вывод методом квадратичного выбора: " + result10);
//Сортировка массива сменой направлений

static void QuadraticSelectionSort(int[] arr)
{
    int blockSize = (int)Math.Sqrt(arr.Length); // Определение размера блока для разбиения массива (квадратный корень от длины массива)

    // Цикл, разбивающий массив на блоки
    for (int i = 0; i < arr.Length; i += blockSize)
    {
        int endIndex = Math.Min(i + blockSize, arr.Length); // Определение конечного индекса текущего блока

        int minIndex = i; // Инициализация индекса минимального элемента текущего блока

        // Цикл для поиска минимального элемента в текущем блоке
        for (int j = i; j < endIndex; j++)
        {
            // Если текущий элемент меньше элемента с минимальным индексом, обновляем минимальный индекс
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }

        // Обмен минимального элемента текущего блока с первым элементом блока (на место i)
        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
}
Console.ReadKey();