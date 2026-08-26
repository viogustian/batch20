using Week4Logic4VioGustian.LinkedListStructures;

namespace Week4Logic4VioGustian;

public class Program
{
    public static void Main()
    {
        var myList = new SequenceLogic();

        myList.Append(15);
        myList.Append(5);
        myList.Append(20);
        myList.Append(8);
        myList.Append(3);

        Console.WriteLine("\n--- Before Filter & Sort ---");
        myList.Print();

        myList.AddFilter(val => val >= 5);
        
        myList.SetSorting((a, b) => a.CompareTo(b));

        Console.WriteLine("\n--- After Filter (>= 5) & Sorted (Ascending) ---");
        myList.Print();
        
        Console.WriteLine("\n--- Print Reverse ---");
        myList.PrintReverse();
    }
}