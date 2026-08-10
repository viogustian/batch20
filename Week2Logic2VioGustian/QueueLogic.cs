namespace Week1Logic2VioGustian;

public class QueueLogic<T>
{
    private List<T> _queue = new List<T>();

    public int Count => _queue.Count;

    public void Enqueue(T val)
    {
        _queue.Add(val);
        Console.WriteLine($"Queued {val}");
    }

    public void EnqueueVip(T val)
    {
        _queue.Insert(0, val);
        Console.WriteLine($"VIP Queued {val}");
    }

    public void Process()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        T val = _queue[0];
        _queue.RemoveAt(0);
        
        Console.WriteLine($"Processed {val}");
    }
}