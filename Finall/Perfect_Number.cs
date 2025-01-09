//Perfect number: A number whose sum of all positive divisors except itself is equal to itself is called a perfect number.
//Example: 6 is a perfect number.because the positive divisors of 6 are 1,2,3 and 6.
//If we add the other divisors except itself, we get 1+2+3=6.
//Find out whether a number entered from the keyboard is a perfect number.

namespace FianlExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Calculate the sum of Divisors(Excluding the number itself)
            int sum = 1; //Start with 1 since every number is divisible by 1.

            for (int i = 2; i< number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i; //sum+=i
                }
            }

            //check if the number is Perfect
            if (sum == number)
            {
                Console.Write(number + " is a Perfect Number.");
            }
            else
            {
                Console.Write(number + " is not a Perfect Number.");
            }
        }
    }
}