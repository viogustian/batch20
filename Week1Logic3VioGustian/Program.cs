using Week1Logic3VioGustian;

StackLogic myStack = new();

myStack.Type("foo");
myStack.Type("bar");

myStack.Undo();
myStack.Undo();

// I added an edge case when calling Undo() again and the stack is already empty
// prints a warning message instead of throwing an error.
// myStack.Undo();