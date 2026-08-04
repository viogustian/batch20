using System.Diagnostics;

namespace Week1_Logic2_VioGustian
{
    public class Program
    {
        static void Main(string[] args)
        {
            QueueLogic myQueue = new();
            myQueue.Enqueue("A");
            myQueue.Enqueue("B");
            myQueue.Process();
            myQueue.Process();

            // I handled the edge case where if Process() is called when the queue is empty, the program returns a warning message instead of throwing an error.
            // myQueue.Process();
        }
    }
}