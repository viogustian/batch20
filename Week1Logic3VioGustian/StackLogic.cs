namespace Week1Logic3VioGustian;

public class StackLogic
{    
    private readonly Stack<string> _words = new();

    public void Type(string word)
    {    
        _words.Push(word);
        Console.WriteLine($"Typed {word}");
    }
    
    public void Undo()
    {
        if(_words.Count==0)
        {
            Console.WriteLine("Nothing to undo.");
            return;
        }
        
        string word = _words.Pop();
        Console.WriteLine($"Undid {word}");
    }
}