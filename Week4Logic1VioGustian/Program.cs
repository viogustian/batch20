namespace Week4Logic1VioGustian;
public class Program
{
    public static void Main()
    {
        var generator = new RuleBasedGenerator();

        generator.AddRule(7, "jazz");
        generator.AddRule(3, "foo");
        generator.AddRule(9, "huzz");
        generator.AddRule(4, "baz");
        generator.AddRule(5, "bar");

        Console.WriteLine(generator.Evaluate(15));
        Console.WriteLine(generator.GenerateSequence(1, 20));
    }
}