/* Define three arrays named Array1, Array2, and Array3 with a size of 10. Populate Array1 and Array2 with random numbers between [0 – 99]. Then multiply the corresponding elements of Array1 and Array2 and store the results in Array3. Finally, print the elements of Array3 to the screen.
 
Dizi1, Dizi2, Dizi3 isminde 10 boyutlu boş diziler tanımlayınız. Dizi1 ve Dizi2 için [0 – 99] arasında rastgele sayılar üretiniz ve dizileri bu sayılarla doldurunuz. Daha sonra iki dizinin elemanlarının çarpımlarını yaparak sonucu Dizi3’e aktarınız. Dizi3’ün elemanlarını ekrana yazdırınız.

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] Array1 = new int[10];
        int[] Array2 = new int[10];
        int[] Array3 = new int[10];

        // Fill Array1 and Array2 with random numbers
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Array1[i] = random.Next(0, 100); // Random number between 0 and 99
            Array2[i] = random.Next(0, 100);
        }

        // Multiply corresponding elements and store in Array3
        for (int i = 0; i < 10; i++)
        {
            Array3[i] = Array1[i] * Array2[i];
        }

        // Print the elements of Array3
        Console.WriteLine("Elements of Array3:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Array1[{i}] * Array2[{i}] = {Array3[i]}");
        }
    }
}
