using Week1Logic2VioGustian;

QueueLogic<String> queue = new QueueLogic<string>();

queue.Enqueue("A");
queue.Enqueue("B");
queue.EnqueueVip("C");
queue.Process();
queue.Process();
queue.Process();