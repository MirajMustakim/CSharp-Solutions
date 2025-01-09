/* string okuPath = "c:\\dosya\\IstiklalMarsi.txt";  
string yazPath = "c:\\dosya\\IstiklalMarsiSonuc.txt";  
string[] kelime = okunan.Split(' '); // Splits the read text into words based on spaces.  
String okunan = File.ReadAllText(path); // Reads the file at the given path.  
File.AppendAllText(path, metin); // Writes the given text to the file at the specified path. If the file does not exist, it creates one.  

Write a void method that reads the first book of the Turkish National Anthem from the file specified by okuPath, finds the longest word, and writes it to the file specified by yazPath.
Additionally, display the longest word on the Console.

*/

using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File paths
        string okuPath = @"C:\dosya\IstiklalMarsi.txt";
        string yazPath = @"C:\dosya\IstiklalMarsiSonuc.txt";

        // Read the text from the file
        string content = File.ReadAllText(okuPath);

        // Split the text into words
        string[] words = content.Split(' ');

        // Find the longest word
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        // Write the longest word to the output file and display it
        File.WriteAllText(yazPath, longestWord);
        Console.WriteLine($"Longest word: {longestWord}");
    }
}
