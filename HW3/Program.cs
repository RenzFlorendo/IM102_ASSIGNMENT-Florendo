using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> GetFrequency(string text)
    {
        var freq = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (char.IsLetter(c))
                freq[c] = freq.ContainsKey(c) ? freq[c] + 1 : 1;
        }
        return freq;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        foreach (string word in Console.ReadLine().Split(','))
        {
            foreach (var kv in GetFrequency(word.Trim()))
                Console.Write($"{kv.Key}={kv.Value}, ");
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
