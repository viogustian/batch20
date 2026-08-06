namespace Week1Logic5VioGustian;

public class CircularQueue<T>
{
    public int Capacity {get; set;}
    public T[] Queue {get; set;}
    public int Front {get; set;}
    public int Rear {get; set;}


    public CircularQueue(int capacity)
    {
        Capacity = capacity;
        Queue = new T[Capacity];
        Front = -1;
        Rear = -1;
    }

    public bool IsEmpty => Front == -1;
    public bool IsFull => (Rear + 1) % Capacity == 0;


    public void Enqueue(T item)
    {
        if(IsFull)
        {
            Console.WriteLine("Queue penuh");
            
        }else
        {
            Front = 0;
        }

        Rear = (Rear + 1) % Capacity;
        Queue[Rear] = item;

    }

    public void Dequeue()
    {
        
    }

}