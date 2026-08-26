namespace Week4Logic3VioGustian;

public class Program
{
    public static void Main()
    {
        var history = new HistoryTracker();
        
        history.AddValidationRule(word => !string.IsNullOrWhiteSpace(word));
        history.AddValidationRule(word => word.Length <= 10);

        history.Type("hello");
        history.Type("");
        history.Type("thisistoolongofaword"); 
    }
}