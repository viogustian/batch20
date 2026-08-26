namespace Week4Logic4VioGustian.LinkedListStructures; 
public class SequenceLogic
{
    private Node? _head;
    private Node? _tail;

    private Func<int, int, int>? _comparer;
    private readonly List<Func<int, bool>> _filters = new();

    public void SetSorting(Func<int, int, int> comparer)
    {
        _comparer = comparer;
    }

    public void AddFilter(Func<int, bool> filterRule)
    {
        _filters.Add(filterRule);
    }

    public void Append(int val)
    {
        Node newNode = new(val);

        if (_head is null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            newNode.Previous = _tail;
            _tail!.Next = newNode;
            _tail = newNode;
        }

        Console.WriteLine($"Appended {val}");
    }

    public void Print()
    {
        List<int> values = new();
        Node? current = _head;

        while (current is not null)
        {
            if (_filters.Count == 0 || _filters.All(rule => rule(current.Value)))
            {
                values.Add(current.Value);
            }
            current = current.Next;
        }

        if (_comparer is not null)
        {
            values.Sort((a, b) => _comparer(a, b));
        }

        Console.WriteLine($"Sequence: {string.Join(" -> ", values)}");
    }

    public void PrintReverse()
    {
        List<int> values = new();
        Node? current = _tail;

        while (current is not null)
        {
            if (_filters.Count == 0 || _filters.All(rule => rule(current.Value)))
            {
                values.Add(current.Value);
            }
            current = current.Previous;
        }

        if (_comparer is not null)
        {
            values.Sort((a, b) => _comparer(a, b));
            values.Reverse(); 
        }

        Console.WriteLine($"Reversed: {string.Join(" -> ", values)}");
    }
}