/*
 Define 20 Dimensional empty arrays names array1, array2 and array3.
Generate random numbers between (0-99) for array1 and array2 and fill the arrays with these numbers.
Then, multiply the elements of array1 and array2 and transfer the result to array 3.
Print the elements of array3 to the screen.
 */

namespace FianlExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Define arrays
            int[] array1 = new int[20];
            int[] array2 = new int[20];
            int[] array3 = new int[20];

            //Fill array1 and array2 with random numbers between 0 and 99
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                array1[i] = random.Next(100);
                array2[i] = random.Next(100);
            }

            //Multiply the elements of array1 and array2 and store the result in array3
            for (int i = 0;i < 20;i++)
            {
                array3[i] = array1[i] * array2[i];
            }

            //print the elements of array3
            Console.WriteLine("Elements of Array 3 : ");
            for (int i = 0; i < 20;i++)
            {
                Console.WriteLine(array3[i]);
            }
        }
    }
}