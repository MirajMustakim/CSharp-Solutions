/* A strong number is a number whose factorial sum of each digit is equal to the number itself.  Example: 145, the factorial of each digit totals: 1!  +4!  +5!  = 1+24+120 = 145, so number 145 is strong number.

 additional information: factorial The product of natural numbers from 1 to n, where n is a positive integer, is called n factorial and n!  It is shown as .  ex: 
0!  = 1 
1!  =1 
2!  = 1.2 = 2
3!= 1.2.3 = 6 
4!  = 1.2.3.4 = 24 
5!  = 1.2.3.4.5= 120. 
Find out whether a number entered from the keyboard is a strong number.
*/

namespace FianlExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine()); // Convert the input string to an integer

            // Check if the number is a Strong Number and display the result
            if (IsStrongNumber(number))
            {
                Console.WriteLine(number + " is a Strong Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Strong Number.");
            }
        }

        // Calculate the factorial of a given number
        static int Factorial(int n)
        {
            int result = 1; // Initialize the result to 1
            for (int i = 1; i <= n; i++) // Loop from 1 to the given number
            {
                result = result * i; // Multiply the result by the current value of i
            }
            return result; // Return the calculated factorial
        }

        // Check if a number is a Strong Number
        static bool IsStrongNumber(int num)
        {
            int originalNum = num; // Store the original number
            int sum = 0; // Initialize the sum of factorials to 0

            while (num > 0) // Loop through each digit of the number
            {
                int digit = num % 10; // Get the last digit of the number
                sum = sum + Factorial(digit); // Add the factorial of the digit to the sum
                num = num / 10; // Remove the last digit from the number
            }

            return sum == originalNum; // Check if the sum of factorials equals the original number
        }
    }
}
