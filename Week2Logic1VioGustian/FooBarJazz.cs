namespace  Week2Logic1VioGustian;
public class FooBarJazz
{
    public static void Generate(int n)
    {
        List<string> results = new List<string>();
        for (int i = 1; i <= n ; i++)
        {
            results.Add(BuildOutput(i));
        }
        Console.WriteLine(string.Join(", ", results));
    }

    public static string BuildOutput(int x)
    {
        string output = string.Empty;

        if(x % 3 == 0)
        {
            output += "Foo";
        }

        if(x % 5 == 0)
        {
            output += "Bar";
        }

        if(x % 7 == 0)
        {
            output += "Jazz";
        }

        return output.Length > 0 ? output : x.ToString();
    }
}