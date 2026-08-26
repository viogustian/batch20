namespace Week4Logic3VioGustian;

public class HistoryTracker
{
    private readonly List<string> _items = new();
    private readonly List<string> _redoItems = new();
    private readonly List<Func<string, bool>> _validationRules = new();
    private int _maxHistory = 3;

    public void AddValidationRule(Func<string, bool> rule)
    {
        _validationRules.Add(rule);
    }

    public void Type(string item)
    {
        if (_validationRules.Any() && !_validationRules.All(rule => rule(item)))
        {
            if (string.IsNullOrWhiteSpace(item))
                Console.WriteLine("Rejected");
            else
                Console.WriteLine($"Rejected {item}");
                
            return;
        }

        _redoItems.Clear();

        if (_items.Count >= _maxHistory)
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
        if (_items.Count == 0)
        {
            Console.WriteLine("Nothing To Undo.");
            return;
        }

        int lastIndex = _items.Count - 1;
        string item = _items[lastIndex];

        _redoItems.Add(item);
        _items.RemoveAt(lastIndex);

        Console.WriteLine($"Undid {item}");
    }

    public void Redo()
    {
        if (_redoItems.Count == 0)
        {
            Console.WriteLine("Nothing To Redo.");
            return;
        }

        int lastIndex = _redoItems.Count - 1;
        string item = _redoItems[lastIndex];

        _redoItems.RemoveAt(lastIndex);
        _items.Add(item);

        Console.WriteLine($"Redid {item}");
    }
}