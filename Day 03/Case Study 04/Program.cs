using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string? word1 = Console.ReadLine();
        string? word2 = Console.ReadLine();

        if (word1 == null || word2 == null)
            return;

        // Set of consonants from word2, lowercase for case-insensitive compare
        HashSet<char> consInWord2 = new HashSet<char>();
        string vowels = "aeiou";
        foreach (char c in word2.ToLower())
        {
            if (!vowels.Contains(c)) // it's a consonant
                consInWord2.Add(c);
        }

        // Step 1: Build string after removing common consonants
        StringBuilder sb = new StringBuilder();
        foreach (char c in word1)
        {
            char lower = char.ToLower(c);
            bool isVowel = vowels.Contains(lower);
            bool isCommonConsonant = !isVowel && consInWord2.Contains(lower);

            if (isVowel || !isCommonConsonant) // keep vowel or non-common consonant
                sb.Append(c);
        }

        // Step 2: Remove consecutive duplicates, case-insensitive
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < sb.Length; i++)
        {
            if (i == 0 || char.ToLower(sb[i])!= char.ToLower(sb[i - 1]))
                result.Append(sb[i]);
        }

        Console.WriteLine(result.ToString());
    }
}