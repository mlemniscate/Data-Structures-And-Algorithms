using System.Drawing;

namespace Data_Structures_And_Algorithms.Linked_Lists;

public class MyLinkedList
{
    // Lookup 
    // ---> By Value O(n)
    // ---> By Index O(n)

    // Insert
    // ---> At the End O(1)
    // ---> At the Beginning O(1)
    // ---> At the Middle O(n)

    // Delete
    // ---> From the Beginning O(1)
    // ---> From the End O(n)
    // ---> From the Middle O(n)

    private Node? first;
    private Node? last;
    private int size;

    public void AddFirst(int value)
    {
        if (IsEmpty())
            first = last = new Node(value);
        
        else
        {
            var oldFirst = first;
            first = new Node(value)
            {
                Next = oldFirst
            };
        }

        size++;
    }

    public void AddLast(int value)
    {
        if (IsEmpty())
            first = last = new Node(value);
        else
        {
            var oldLast = last;
            last = new Node(value);
            oldLast.Next = last;
        }

        size++;
    }

    public void RemoveFirst()
    {
        if (IsEmpty())
            throw new InvalidOperationException();

        if (first == last)
            first = last = null;
        else
        {
            var second = first.Next;
            first.Next = null;
            first = second;
        }

        size--;
    }

    public void RemoveLast()
    {
        if (IsEmpty())
            throw new InvalidOperationException();

        if (first == last)
            first = last = null;
        else
        {
            var previous = GetPrevious(last);
            last = previous;
            last.Next = null;
        }

        size--;
    }

    public bool Contains(int value)
    {
        return IndexOf(value) != -1;
    }

    public int IndexOf(int value)
    {
        var node = first;
        var index = 0;
        while (node != null)
        {
            if (node.Value.Equals(value))
                return index;
            node = node.Next;
            index++;
        }
        return -1;
    }

    public int Size()
    {
        return size;
    }

    public void Print()
    {
        var node = first;
        while (node != last)
        {
            Console.WriteLine(node.Value);
            node = node.Next;
        }
        Console.WriteLine(node.Value);
    }

    public int[] ToArray()
    {
        int[] array = new int[size];
        var current = first;
        var index = 0;
        while (current != null)
        {
            array[index++] = current.Value;
            current = current.Next;
        }
        return array;
    }

    private bool IsEmpty()
    {
        return first == null;
    }

    private Node GetPrevious(Node node)
    {
        var current = first;
        while (current != null)
        {
            if (current.Next == node) return current;
            current = current.Next;
        }

        return null;
    }

    public void Main()
    {
        // LinkedList<int> list = new LinkedList<int>();
        // list.AddLast(10);
        // list.AddLast(20);
        // list.AddLast(30);
        // list.AddFirst(5);
        // list.RemoveLast();
        // list.RemoveFirst();
        //
        // foreach (var item in list)
        // {
        //     Console.WriteLine(item);
        // }
        //
        // Console.WriteLine("Contain: " + list.Contains(5));
        // Console.WriteLine("Contain: " + list.Find(5));
        // Console.WriteLine("Contain: " + list.Contains(5));

        var myLinkedList = new MyLinkedList();
        myLinkedList.AddLast(-10);
        myLinkedList.AddLast(-20);
        myLinkedList.AddFirst(10);
        myLinkedList.AddFirst(20);
        myLinkedList.AddFirst(30);
        myLinkedList.RemoveLast();
        Console.WriteLine(myLinkedList.Contains(30));
        Console.WriteLine(myLinkedList.Contains(-20));
        Console.WriteLine(myLinkedList.IndexOf(-10));
        Console.WriteLine(myLinkedList.IndexOf(-20));
        myLinkedList.Print();
        Console.WriteLine(myLinkedList.Size());
    }
}