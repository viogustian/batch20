namespace Week1Logic4VioGustian.LinkedListStructures;

public class SequenceLogic
{
    private Node? _head;
    private Node? _tail;

    public void Append(int val)
    {
        Node newNode = new(val);

        if(_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }else
        {
            _tail!.Next = newNode;
            _tail = newNode;   
        }

        Console.WriteLine($"Appended {val}");

    }

    public void Print()
    {
        List<string> values = new();
        Node? current = _head;

        while(current is not null)
        {
            values.Add(current.Value.ToString());
            current = current.Next;
        }

        Console.WriteLine($"Sequence: {string.Join("->", values)}");
    }
}