//№3.1
//Создание списка
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

List<int> L = new List<int>();
{
    L.Insert(0, 3);
    L.Insert(0, 11);
    L.Insert(0, 6);
    L.Insert(0, 15);
}
foreach (var item in L)
{
    Console.WriteLine(item);
}

//Проверка на пустой список
double sum = 0;
double srAr = 0;
static bool IsEmptyList(List<int> L)
{
    return L.Count == 0;
}

if (IsEmptyList(L))
{
    Console.WriteLine("Список пуст");
}
//Если список не пустой, то расчет среднего арифметического
else
{
    Console.WriteLine("Список не пуст");
    foreach (var item in L)
    {
        sum += item;
    }
    srAr = sum / L.Count;
    Console.WriteLine($"Значит среднее арифметическое:{srAr}");

    //Замена первого и последнего элементов непустого списка
    int count = 0;
    int E1 = 0, E2 = 0, E0;
    foreach (var item in L)
    {
        count++;
        if (count == 1) E1 = item;
        if (count == L.Count) E2 = item;
    }
    E0 = E2;
    E2 = E1;
    E1 = E0;
    L[0] = E1;
    L[L.Count - 1] = E2;
    Console.WriteLine("\nПоменяный список первого и последнего элементов местами: ");
    foreach (var item in L)
    {
        Console.WriteLine(item);
    }

    //Проверка на упорядоченность списка
    for (int i = 1; i < L.Count; i++)
    {
        if (L[i] < L[i - 1])
        {
            count = 1;
            break;
        }
        else if (L[i] == L[L.Count - 1] && (L[i] < L[i - 1])) count = 0;
    }
    if (count == 1) Console.WriteLine("Список не упорядочен");
    else Console.WriteLine("Список упорядочен");
}

//Создание второго списка
LinkedList<int> L1 = new LinkedList<int>();
{
    L1.AddFirst(15);
    L1.AddFirst(6);
    L1.AddFirst(10);
    L1.AddFirst(30);
}
Console.WriteLine("\n\nСписок №2:");
foreach (var item in L1)
{
    Console.WriteLine(item);
}
//Нахождение суммы последнего и предпоследнего элементов списка
Console.WriteLine("\nСумма последнего и предпоследнего элементов списка");
var lastNode = L1.Last;
var secondLastNode = lastNode.Previous;
foreach (var item in L1)
{
    if (L1.Count > 1)
    {
        Console.WriteLine(lastNode.Value + secondLastNode.Value);
        break;
    }
    else Console.WriteLine("Список содержит менее двух элементов");
}

//№3.2
//В список L2 входит по одному элементу L1 и L
Console.WriteLine("\nНовый список, в котором содержится как минимум один элемент из списков L1 и L2");
List<int> L2 = new List<int>();
{
    L2.Insert(0, 99);
    L2.Insert(0, 66);
}

foreach (var item in L1)
{
    if (L1.Contains(item)) L2.Add(item);
    break;
}
foreach (var item in L)
{
    if (L.Contains(item)) L2.Add(item);
    break;
}
foreach (var item in L2)
{
    Console.WriteLine(item);
}


//№3.2
LinkedList<int> L222 = new LinkedList<int>();
{
    L222.AddLast(1);
    L222.AddLast(2);
    L222.AddLast(3);
    L222.AddLast(4);
}

LinkedList<int> L2222 = new LinkedList<int>();
{
    L2222.AddLast(5);
    L2222.AddLast(2);
    L2222.AddLast(3);
    L2222.AddLast(4);
}

Console.WriteLine("\n Новый список, в котором не содержатся элементы, которые одновременно находятся в L1 и L2");
LinkedList<int> L22 = new LinkedList<int>();

foreach (var item in L222)
{
    if (!L2222.Contains(item) && !L22.Contains(item))
    {
        L22.AddLast(item);
    }
}

foreach (var item in L2222)
{
    if (!L222.Contains(item) && !L22.Contains(item))
    {
        L22.AddLast(item);
    }
}

foreach (var item in L22)
{
    Console.WriteLine(item);
}


//№3.3
List<int> L33 = new List<int>();
{
    L33.Insert(0, 15);
    L33.Insert(0, 11);
    L33.Insert(0, 6);
    L33.Insert(0, 3);
}
List<int> L333 = new List<int>();
{
    L333.Insert(0, 15);
    L333.Insert(0, 11);
    L333.Insert(0, 6);
    L333.Insert(0, 3);
}
Console.WriteLine("\nОбьединение списков L1 и L2 упорядоченных по неубыванию");
LinkedList<int> L3 = new LinkedList<int>();
foreach (var item in L33)
{L3.AddLast(item);}

foreach (var item in L333)
{L3.AddLast(item);}
var sortedList = new LinkedList<int>();
foreach (var item in L3)
{
    var node = sortedList.First;
    while (node != null && item > node.Value) 
    { node = node.Next; }

    if (node != null) sortedList.AddBefore(node, item);
    else sortedList.AddLast(item);
}

foreach (var item in sortedList)
{Console.WriteLine(item);}

Console.ReadKey();