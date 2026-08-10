public class FooBarjazz
{
    public static void Generate(int n)
    {
        List<string> results = new List<string>();
        for (int i = 0; i <= n ; i++)
        {
            results.Add(BuildOutput(i));
        }
        Console.WriteLine(string.Join(", ", results));
    }

    
}