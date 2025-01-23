/* "Write a method that checks whether a given number is prime. If the number is already prime, return it as it is. If it is not prime, find the next prime number and return it."

Example Outputs:

Input: 120 → Output: 127
Input: 321 → Output: 323
Input: 17 → Output: 17

"Kullanıcıdan alınan bir tam sayıdan sonra gelen ilk asal sayıyı bulan bir metot yazınız. Eğer girilen sayı zaten asalsa, o sayıyı döndürün."

Örnek Çıktılar:

Giriş: 120 → Çıkış: 127
Giriş: 321 → Çıkış: 331
Giriş: 17 → Çıkış: 17

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");

        // Read the user input and convert it to an integer
        // Using Convert.ToInt32 for safe conversion
        int number = Convert.ToInt32(Console.ReadLine());

        // Call the method to find the next or the same prime number
        int result = FindNextOrSamePrime(number);

        // Print the result to the console
        Console.WriteLine("Output: " + result);
    }

    // Method to check if a number is prime
    static bool IsPrime(int num)
    {
        // Numbers less than 2 are not prime
        if (num < 2) return false;

        // Loop to check divisors up to the square root of the number
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            // If the number is divisible by i, it is not prime
            if (num % i == 0) return false;
        }

        // If no divisors are found, the number is prime
        return true;
    }

    // Method to find the next or the same prime number
    static int FindNextOrSamePrime(int num)
    {
        // Keep incrementing the number until a prime is found
        while (!IsPrime(num))
        {
            num++; // Increment the number
        }

        // Return the first prime number found
        return num;
    }
}
