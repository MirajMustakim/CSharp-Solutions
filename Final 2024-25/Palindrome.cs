/* "Write a code that takes a word or a short sentence as input (e.g., 'kabak') and checks whether it is a palindrome. Print the result as either 'Palindrome' or 'Not Palindrome'."

Girilen bir kelime veya kısa cümle (örneğin “kabak”) palindrom mudur değil midir kontrol eden kod yazınız. Ekrana “Palindrome” veya “Palindrome Değil” sonucunu döndürünüz.
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter a word or sentence: ");
        string input = Console.ReadLine();

        // Check if it is a palindrome
        if (IsPalindrome(input))
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }

    // Method to check for palindrome
    static bool IsPalindrome(string text)
    {
        // Normalize the input: remove spaces, make it lowercase
        string normalized = text.Replace(" ", "").ToLower();

        // Reverse the string
        char[] charArray = normalized.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        // Compare normalized string with its reverse
        return normalized == reversed;
    }
}
