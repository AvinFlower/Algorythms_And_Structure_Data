int V = 6; // Количество вершин в графе
Graph graph = new Graph(V); // Создание экземпляра графа с заданным количеством вершин

// Добавление рёбер в граф
graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(1, 3);
graph.AddEdge(2, 4);
graph.AddEdge(3, 5);

Console.WriteLine("Результат DFS (начиная с вершины 0): ");
graph.DFS(0);
Console.WriteLine();
Console.WriteLine("Матрица смежности:");
graph.PrintMatrix();

Console.WriteLine();
Console.Write("Введите элемент для поиска в графе: ");
if (int.TryParse(Console.ReadLine(), out int inputElement))
{
    List<(int, int)> foundElements = graph.FindElementInVertices(inputElement);
    if (foundElements.Count > 0)
    {
        Console.WriteLine("Элемент найден в следующих ячейках матрицы:");
        foreach (var element in foundElements)
        {
            Console.WriteLine("Строка " + element.Item1 + ", Столбец " + element.Item2);
        }
    }
    else
    {
        Console.WriteLine("Элемент не найден в графе.");
    }
}

Console.ReadLine();

class Graph
{
    private int V; // Количество вершин
    private int[,] adjacencyMatrix;

    public Graph(int v)
    {
        V = v;
        adjacencyMatrix = new int[v, v]; // Инициализация матрицы
    }

    // Метод для добавления ребра от вершины start к вершине end
    public void AddEdge(int start, int end)
    {
        Random random = new Random();
        int weight = random.Next(1, 11);
        adjacencyMatrix[start, end] = weight;
    }

    // Метод для выполнения поиска в глубину (DFS) начиная с заданной вершины
    public void DFS(int startNode)
    {
        bool[] visited = new bool[V];
        Stack<int> stack = new Stack<int>();
        stack.Push(startNode); // Помещаем начальную вершину в стек

        while (stack.Count > 0) // Пока стек не пуст
        {
            int node = stack.Pop(); // Извлекаем вершину из стека
            if (!visited[node]) // Если вершина не была посещена
            {
                visited[node] = true;
                Console.Write(node + " ");

                // Просматриваем соседей вершины (обратный порядок для определения порядка обхода)
                for (int i = V - 1; i >= 0; i--)
                {
                    if (adjacencyMatrix[node, i] > 0 && !visited[i]) // Если существует направленное ребро и соседняя вершина не была посещена
                    {
                        stack.Push(i); // Добавляем соседнюю вершину в стек для будущего исследования
                    }
                }
            }
        }

    }

    // Вспомогательный метод для рекурсивного выполнения DFS
    private void DFSUtil(int node, bool[] visited)
    {
        visited[node] = true; // Помечаем текущую вершину как посещенную

        // Просматриваем соседние вершины
        for (int i = 0; i < V; i++)
        {
            // Если существует направленное ребро и соседняя вершина не была посещена
            if (adjacencyMatrix[node, i] > 0 && !visited[i])
            {
                DFSUtil(i, visited);
            }
        }

        Console.Write(node + " "); // Выводим номер текущей вершины
    }

    // Метод для поиска элемента и возврата списка (строка, столбец) пар
    public List<(int, int)> FindElementInVertices(int element)
    {
        List<(int, int)> foundElements = new List<(int, int)>();

        for (int row = 0; row < V; row++)
        {
            for (int col = 0; col < V; col++)
            {
                if (adjacencyMatrix[row, col] == element)
                {
                    foundElements.Add((row, col));
                }
            }
        }

        return foundElements;
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                Console.Write(adjacencyMatrix[i, j] + " ");
            }
            Console.WriteLine(); // Переход на новую строку для следующей вершины
        }
    }
}