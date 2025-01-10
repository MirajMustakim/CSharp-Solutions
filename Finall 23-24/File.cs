/* Write the code that counts the number of words and the text length excluding spaces in the file at the 
  path C://Dosya//islem.txt, and saves the results in the file C://Dosya//sonuc.txt." 

 "C://Dosya//islem.txt" dosya yolundaki kelime sayısını, 
boşluklar hariç metin uzunluğunu "C://Dosya//sonuc.txt" dosyasına
kaydeden kodu yazın.
*/

namespace Final_23_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"C://Dosya//islem.txt";
            string outputFilePath = @"C://Dosya//sonuc.txt";

            // Read the content of the input file
            string text = File.ReadAllText(inputFilePath);

            // Count words
            int wordCount = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Calculate text length excluding spaces
            int textLength = text.Replace(" ", "").Replace("\n", "").Replace("\r", "").Length;

            // Prepare the result
            string result = $"Word Count: {wordCount}\nText Length (excluding spaces): {textLength}";

            // Write the result to the output file
            File.WriteAllText(outputFilePath, result);

            Console.WriteLine("The result has been saved to sonuc.txt.");
        }
    }
}
