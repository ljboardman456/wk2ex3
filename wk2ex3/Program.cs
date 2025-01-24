using System;

class Program
{
    static void Main()
    {
        // Ask the user to input a string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Initialize a variable to count vowels
        int vowelCount = 0;

        // Loop through each character in the string
        foreach (char ch in input)
        {
            // Check if the character is a vowel
            if ("aeiouAEIOU".IndexOf(ch) >= 0)
            {
                vowelCount++;
            }
        }

        // Display the result
        Console.WriteLine($"The number of vowels in the string is: {vowelCount}");
    }
}
