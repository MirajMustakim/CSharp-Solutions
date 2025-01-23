/* "Write a method that reads a file (e.g., a text file named 'metin.txt') line by line, splits the content of the file into words, and finds the longest word in the text and its length, then prints them on the screen."

Hint:
File.ReadAllText(path) // Reads the entire file content as a single string.
string[] words = content.Split(' '); // Splits the content into words based on spaces.

Bir dosyadaki cümleyi okuyarak (örneğin metin.txt içerisinde "C sharp ile algoritma geliştirmek çok eğlenceli"), içerisindeki en uzun kelimeyi ve kelimenin uzunluğunu ekrana yazdıran bir metot yazınız.

*/

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Call the method to find the longest word
        FindLongestWord("metin.txt");
    }

    static void FindLongestWord(string filePath)
    {
        // Read all content from the file
        string content = File.ReadAllText(filePath);

        // Split the content into words
        string[] words = content.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Find the longest word
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        // Print the longest word and its length
        Console.WriteLine("Longest Word: " + longestWord);
        Console.WriteLine("Length: " + longestWord.Length);
    }
}

