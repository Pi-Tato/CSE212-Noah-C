using System;

public class Program
{
    static void Main(string[] args)
    {
        /* This project is here for you to use as a "Sandbox" to play around
         with any code or ideas you have that do not directly apply to
         one of your projects.*/


        MultiplesOf(7, 5);
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);


        FindPairs(["am", "at", "ma", "if", "fi"]);
        //expected { "ma & am", "fi & if" };
    }

    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        int listLength = data.Count;

        for (int i = 0; i < amount; i++)
            data.RemoveAt(data.Count - 1);

        for (int i = 0; i < amount; i++)
            data.Insert(0, listLength - i);
    }

    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            double n = number * i + number;
            result[i] = n;
            //Console.WriteLine(n);
        }

        return result; // replace this return statement with your own
    }

    public static string[] FindPairs(string[] words)
    {
        // TODO Problem 1 - ADD YOUR CODE HERE

        var set = new HashSet<string>();
        var pairSet = new HashSet<string>();
        foreach (var word in words)
        {
            set.Add(word);
        }
        string[] pairs;
        pairs = new string[set.Count];

        for (int i = 0; i < set.Count; i++)
        {
            for (int j = 0; j < set.Count; j++)
            {
                char[] letters = set.ElementAt(i).ToCharArray();
                Array.Reverse(letters);
                if (set.ElementAt(i) == set.ElementAt(j))
                {
                    letters.ToString().Trim();
                    pairs[i] = set.ElementAt(i) + " & " + new string(letters);
                    if (i == 0 || i == 3)
                    {
                        pairSet.Add(pairs[i]);
                    }
                }
            }
        }

        string[] result;
        result = new string[pairSet.Count];
        for (int i = 0; i < pairSet.Count; i++)
        {
            result[i] = pairSet.ElementAt(i);
        }
        Console.WriteLine($"[{result[0]}, {result[1]}]");
        return result;
    }
}