namespace Week3Logic5VioGustian;

public class CircularQueue<T>
{
    private const int WarningThresholdPercent = 66;
    private const int CriticalThresholdPercent = 100;

    private int _capacity;
    private T[] _queue;
    private int _front;
    private int _rear;

    public CircularQueue(int capacity)
    {
        _capacity = capacity;
        _queue = new T[_capacity];
        _front = -1;
        _rear = -1;
    }

    public int Capacity => _capacity;
    public bool IsEmpty => _front == -1;
    public bool IsFull => (_rear + 1) % Capacity == _front;

    private int Count
    {
        get
        {
            if (IsEmpty) return 0;
            if (IsFull) return Capacity;
            return (_rear - _front + Capacity) % Capacity + 1;
        }
    }

    private double UtilizationPercent => (double)Count / Capacity * 100;

    private void CheckAlerts()
    {
        if (UtilizationPercent >= CriticalThresholdPercent)
        {
            Console.WriteLine("Critical: Buffer Full");
        }
        else if (UtilizationPercent >= WarningThresholdPercent)
        {
            Console.WriteLine($"Warning: Buffer at {WarningThresholdPercent}%");
        }
    }

    public void Log(T item)
    {
        CheckAlerts();

        if (IsFull)
        {
            _front = (_front + 1) % Capacity;
            Console.WriteLine($"Overwritten oldest with {item}");
            _rear = (_rear + 1) % Capacity;
            _queue[_rear] = item;
            return;
        }

        if (IsEmpty)
        {
            _front = 0;
        }
        _rear = (_rear + 1) % Capacity;
        _queue[_rear] = item;
        Console.WriteLine($"Logged {item}");
    }

    public T? Read()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Log is Empty.");
            return default;
        }

        T item = _queue[_front];

        if (_rear == _front)
        {
            _rear = -1;
            _front = -1;
        }
        else
        {
            _front = (_front + 1) % Capacity;
        }
        Console.WriteLine($"Read {item}");
        return item;
    }
}