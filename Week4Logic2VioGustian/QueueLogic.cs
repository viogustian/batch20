namespace Week4Logic2VioGustian;

public class KeywordPriorityQueue<T>
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
    private readonly Dictionary<string, int> _rules = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    public int Count => _queue.Count;

    public void AddRule(string keyword, int priority)
    {
        if (string.IsNullOrWhiteSpace(keyword)) return;

        _rules[keyword] = priority;
    }

    public void Enqueue(T val)
    {
        int priority = 0;
        string stringVal = val?.ToString() ?? string.Empty;

        foreach (var rule in _rules)
        {
            if (stringVal.Contains(rule.Key, StringComparison.OrdinalIgnoreCase))
            {
                if (rule.Value > priority)
                {
                    priority = rule.Value;
                }
            }
        }

        _queue.Add(new QueueItem(val, priority));
        Console.WriteLine($"Queued {val} with priority {priority}");
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