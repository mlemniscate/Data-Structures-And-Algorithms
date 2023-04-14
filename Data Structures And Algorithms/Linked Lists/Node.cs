namespace Data_Structures_And_Algorithms.Linked_Lists;

public class Node
{
    public int Value { get; set; }
    public Node? Next { get; set; }

    public Node(int value)
    {
        Value = value;
    }
}