namespace Week4Logic2VioGustian;

public class Program
{
    public static void Main()
    {
        var queue = new KeywordPriorityQueue<string>();

        queue.AddRule("urgent", 10);
        queue.AddRule("normal", 5);

        queue.Enqueue("normal");
        queue.Enqueue("urgent");

        queue.Process();
        queue.Process();
    }
}