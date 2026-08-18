namespace Week3Logic1VioGustian;

public class FooBazHuzz
{
    public static void Generate(int n)
    {
        List<string> results = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            results.Add(BuildOutput(i));
        }

        Console.WriteLine(string.Join(", ", results));
    }

    public static string BuildOutput(int x)
    {
        string output = string.Empty;

        if (x % 3 == 0)
        {
            output += "foo";
        }

        if (x % 4 == 0)
        {
            output += "baz";
        }

        if (x % 5 == 0)
        {
            output += "bar";
        }

        if (x % 7 == 0)
        {
            output += "jazz";
        }

        if (x % 9 == 0)
        {
            output += "huzz";
        }

        return output.Length > 0 ? output : x.ToString();
    }
}