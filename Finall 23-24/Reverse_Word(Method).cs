/* Write a method in C# that takes a word as an argument and prints its reverse.
Bir kelime argüman olarak girildiğinde tersten okunuşunu yazan metotu yazınız.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();

        // Call the method to reverse the word
        string reversedWord = ReverseWord(word);

        Console.WriteLine("Reversed: " + reversedWord);
    }

    static string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray(); // Convert the word to a character array
        Array.Reverse(charArray);             // Reverse the character array
        return new string(charArray);         // Convert back to a string
    }
}
