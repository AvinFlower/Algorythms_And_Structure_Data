class Deque<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    // Добавить элемент в начало очереди
    public void AddFront(T item)
    {
        list.AddFirst(item);
    }
    // Добавить элемент в конец очереди
    public void AddBack(T item)
    {
        list.AddLast(item);
    }
    // Удалить и вернуть элемент с начала очереди
    public T RemoveFront()
    {
        if (list.Count == 0) throw new InvalidOperationException("Deque is empty");
        T item = list.First.Value;
        list.RemoveFirst();
        return item;
    }
    // Удалить и вернуть элемент с конца очереди
    public T RemoveBack()
    {
        if (list.Count == 0) throw new InvalidOperationException("Deque is empty");
        T item = list.Last.Value;
        list.RemoveLast();
        return item;
    }
    // Получить элемент с начала очереди без его удаления
    public T PeekFront()
    {
        if (list.Count == 0) throw new InvalidOperationException("Deque is empty");
        return list.First.Value;
    }
    // Получить элемент с конца очереди без его удаления
    public T PeekBack()
    {
        if (list.Count == 0) throw new InvalidOperationException("Deque is empty");
        return list.Last.Value;
    }
}
class Program
{
    static void Main()
    {
        Deque<int> deque = new Deque<int>();

        deque.AddBack(1);
        deque.AddFront(2);
        deque.AddBack(3);
        Console.WriteLine("Front: " + deque.PeekFront()); // Выводит "Front: 2"
        Console.WriteLine("Back: " + deque.PeekBack());   // Выводит "Back: 3"
        deque.RemoveFront();
        Console.WriteLine("Front: " + deque.PeekFront()); // Выводит "Front: 1"
        deque.RemoveBack();
        Console.WriteLine("Back: " + deque.PeekBack());   // Выводит "Back: 1"
    }
}