using Week1Logic5VioGustian;

CircularQueue<int> buffer = new CircularQueue<int>(3);

buffer.Log(1);
buffer.Log(2);
buffer.Log(3);
buffer.Log(4);

buffer.Read();