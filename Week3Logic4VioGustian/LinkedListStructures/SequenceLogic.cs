namespace Week3Logic4VioGustian.LinkedListStructures; // Ubah namespace sesuai kebutuhan (misal ke Week 3)

public class SequenceLogic
{
    private Node? _head;
    private Node? _tail;

    public void Insert(int val)
    {
        Node newNode = new(val);

        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else if (val <= _head.Value)
        {
            newNode.Next = _head;
            _head.Previous = newNode;
            _head = newNode;
        }
        else
        {
            Node? current = _head.Next;

            while (current is not null && current.Value < val)
            {
                current = current.Next;
            }
            if (current is null)
            {
                newNode.Previous = _tail;
                _tail!.Next = newNode;
                _tail = newNode;
            }
            else
            {
                newNode.Next = current;
                newNode.Previous = current.Previous;
                
                current.Previous!.Next = newNode;
                current.Previous = newNode;
            }
        }

        Console.WriteLine($"Inserted {val}");
    }

    public void Print()
    {
        List<string> values = new();
        Node? current = _head;

        while (current is not null)
        {
            values.Add(current.Value.ToString());
            current = current.Next;
        }

        Console.WriteLine($"Sequence: {string.Join(" -> ", values)}");
    }

    public void PrintReverse()
    {
        List<string> values = new();
        Node? current = _tail;

        while (current is not null)
        {
            values.Add(current.Value.ToString());
            current = current.Previous;
        }

        Console.WriteLine($"Reversed: {string.Join(" -> ", values)}");
    }
}