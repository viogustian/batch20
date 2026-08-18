using Week3Logic2VioGustian;

QueueLogic<string> queue = new QueueLogic<string>();

queue.Enqueue("A", 1);
queue.Enqueue("B", 5);
queue.Enqueue("C", 5);

queue.Process();
queue.Process();