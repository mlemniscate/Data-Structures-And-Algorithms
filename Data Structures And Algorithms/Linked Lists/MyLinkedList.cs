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

    public void AddFirst(int value)
    {
        if (first == null)
        {
            first = new Node(value);
            last ??= first;
        }
        else
        {
            var oldFirst = first;
            first = new Node(value)
            {
                Next = oldFirst
            };
        }
    }

    public void AddLast(int value)
    {
        if (last == null)
        {
            last = new Node(value);
            first ??= last;
        }
        else
        {
            var oldLast = last;
            last = new Node(value);
            oldLast.Next = last;
        }
    }

    public void DeleteFirst()
    {
        first = first.Next;
    }

    public void DeleteLast()
    {
        var node = first;
        while (node.Next != last)
        {
            node = node.Next;
        }
        last = node;
        last.Next = null;
    }

    public bool Contains(int value)
    {
        var node = first;
         while (node != null)
        {
            if (node.Value.Equals(value))
                return true;
            node = node.Next;
        }
        return false;
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
        myLinkedList.DeleteLast();
        Console.WriteLine(myLinkedList.Contains(30));
        Console.WriteLine(myLinkedList.Contains(-20));
        Console.WriteLine(myLinkedList.IndexOf(-10));
        Console.WriteLine(myLinkedList.IndexOf(-20));
        myLinkedList.Print();
    }
}