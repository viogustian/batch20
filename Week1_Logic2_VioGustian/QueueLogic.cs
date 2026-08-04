namespace Week1_Logic2_VioGustian
{
    public class QueueLogic
    {
        private Queue<string> _queue = new();
        public void Enqueue(string val)
        {
            _queue.Enqueue(val);
            Console.WriteLine($"Queued {val}");
        }
        public void Process()
        {
            if(_queue.Count > 0)
            {
                string val = _queue.Dequeue();
                Console.WriteLine($"Processed {val}");
                
            }else
            {
                Console.WriteLine("Queue is Empty");
            }
        }
    }
}