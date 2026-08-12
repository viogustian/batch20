namespace Week2Logic3VioGustian;

public class StackLogic
{
    private readonly List<object> _items = new();
    private int _maxHistory = 3;

    public void Type(object item)
    {
        if(_items.Count >= _maxHistory)
        {
            _items.RemoveAt(0);
            _items.Add(item);

            Console.WriteLine($"Dropped bottom, Typed {item}");
            return;
        }
        _items.Add(item);
        Console.WriteLine($"Typed {item}");
    }

    public void Undo()
    {
        if(_items.Count == 0)
        {
            Console.WriteLine();
        }

        int lastIndex = _items.Count - 1;
        object item = _items[lastIndex];

        _items.RemoveAt(lastIndex);

        Console.WriteLine($"Undid {item}");
    }
}