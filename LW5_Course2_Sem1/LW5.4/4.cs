Console.WriteLine("Реализация стека");
Stack<int> s = new Stack<int>(); //создали пустой стек
// добавляем элементы:
s.Push(3); // в стеке 3
s.Push(5); // в стеке 5, 3
s.Push(8); // в стеке 8, 5, 3
foreach(var item in s)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nРеализация очереди");
Queue<string> q = new Queue<string>(); //создали пустую очередь
// добавляем элементы:
q.Enqueue("А");
q.Enqueue("Б");
q.Enqueue("В") ;// в очереди В, Б, А
foreach (var item in q)
{
    Console.WriteLine(item);
}

Console.ReadKey();