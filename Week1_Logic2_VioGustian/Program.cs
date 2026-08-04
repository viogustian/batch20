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
            myQueue.Process();
        }
    }
}