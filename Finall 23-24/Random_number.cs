﻿/* )  "Generate 1000 random numbers between 200 and 300. Display numbers that repeat more than 15 times along with how many times they are repeated.
Example:
203 occurs 20 times.
250 occurs 16 times."
*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] numbers = new int[1000];

        // Generate 1000 random numbers between 200 and 300
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(200, 301);
        }

        // Count occurrences of each number
        var numberCounts = numbers.GroupBy(n => n)
                                  .ToDictionary(g => g.Key, g => g.Count());

        // Find and display numbers that occur more than 15 times
        foreach (var kvp in numberCounts.Where(kvp => kvp.Value > 15))
        {
            Console.WriteLine($"{kvp.Key} occurs {kvp.Value} times.");
        }
    }
}