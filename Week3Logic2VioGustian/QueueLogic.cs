namespace Week3Logic2VioGustian;

public class QueueLogic<T>
{
    private class QueueItem
    {
        public T Value { get; set; }
        public int Priority { get; set; }

        public QueueItem(T value, int priority)
        {
            Value = value;
            Priority = priority;
        }
    }

    private readonly List<QueueItem> _queue = new List<QueueItem>();

    public int Count => _queue.Count;

    public void Enqueue(T val, int p)
    {
        _queue.Add(new QueueItem(val, p));
        Console.WriteLine($"Queued {val} with priority {p}");
    }

    public void Process()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }

        int highestIndex = 0;

        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > _queue[highestIndex].Priority)
            {
                highestIndex = i;
            }
        }

        QueueItem item = _queue[highestIndex];
        _queue.RemoveAt(highestIndex);

        Console.WriteLine($"Processed {item.Value}");
    }
}