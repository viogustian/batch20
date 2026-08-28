using Week4Logic5VioGustian;

CircularQueue<string> buffer = new CircularQueue<string>(3);

buffer.Log("A");
buffer.Log("B");
buffer.Log("C");
buffer.Log("D");

buffer.SetOverwritePolicy(false);
buffer.Log("E");

buffer.Read();
buffer.Read();

buffer.SetCapacity(5);
buffer.Log("F");