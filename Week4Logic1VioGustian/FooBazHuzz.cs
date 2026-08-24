using System;
using System.Collections.Generic;

namespace Week4Logic1VioGustian;

public class RuleBasedGenerator
{
    private readonly SortedDictionary<int, string> _rules = new();

    public void AddRule(int divisor, string output)
    {
        if (divisor == 0)
        {
            throw new ArgumentException("Divisor cannot be zero.", nameof(divisor));
        }

        _rules[divisor] = output;
    }

    public string Evaluate(int number)
    {
        string output = string.Empty;

        foreach (var rule in _rules)
        {
            if (number % rule.Key == 0)
            {
                output += rule.Value;
            }
        }

        return output.Length > 0 ? output : number.ToString();
    }

    public string GenerateSequence(int start, int end)
    {
        if (start > end)
        {
            throw new ArgumentException("Start must be less than or equal to end.");
        }

        List<string> results = new List<string>();

        for (int i = start; i <= end; i++)
        {
            results.Add(Evaluate(i));
        }

        return string.Join(", ", results);
    }
}