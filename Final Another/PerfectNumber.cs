/* Perfect Number: A number is called a perfect number if the sum of its positive divisors (excluding itself) equals the number. For example, 6 is a perfect number because its positive divisors are 1, 2, 3, and 6. Excluding itself, the sum of the divisors is 1 + 2 + 3 = 6.
Write C# code to find all perfect numbers between 1 and 1000.

Mükemmel Sayı: Tüm pozitif bölenlerinin toplamı kendisine eşit olan sayılara mükemmel sayı denir. Örneğin, 6 bir mükemmel sayıdır. Çünkü 6'nın pozitif bölenleri 1, 2, 3 ve 6'dır. Kendisi hariç diğer bölenleri toplarsak 1 + 2 + 3 = 6 eder.
1-1000 arası mükemmel sayıları bulan C# kodunu yazınız.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Perfect numbers between 1 and 1000:");

        for (int number = 1; number <= 1000; number++)
        {
            if (IsPerfectNumber(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsPerfectNumber(int num)
    {
        int sum = 0;

        // Find divisors and calculate their sum
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0) // If i is a divisor of num
            {
                sum += i;
            }
        }

        return sum == num; // Return true if the sum of divisors equals the number
    }
}
