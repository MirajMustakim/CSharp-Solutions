/* "Write a code that removes duplicate characters from a given text and leaves only one occurrence of each character."

Example:
Input: algoritmaaaa → Output: algoritm

"Girilen bir metindeki tekrar eden karakterleri çıkartıp, her karakterden yalnızca bir tane bırakan kodu yazınız."
Ornek: "algoritmaaaa → algoritm
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Remove duplicate characters
        string result = RemoveDuplicates(input);

        // Output the result
        Console.WriteLine("Result: " + result);
    }

    // Method to remove duplicate characters
    static string RemoveDuplicates(string str)
    {
        string result = ""; // Store unique characters

        foreach (char c in str)
        {
            // Add the character only if it's not already in the result
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        
        return result;
    }
}
