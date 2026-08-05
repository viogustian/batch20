namespace Week1Logic3VioGustian;

public class StackLogic
{
    private readonly List<object> _items = new();

    public void Type(object item)
    {
        _items.Add(item);
        Console.WriteLine($"Typed {item}");
    }

    public void Undo()
    {    
        if(_items.Count == 0)
        {
            Console.WriteLine("Nothing to undo.");
        }

        int LastIndex = _items.Count - 1; 
        object item = _items[LastIndex];
        _items.RemoveAt(LastIndex);
        Console.WriteLine($"Undid {item}");
    }
}