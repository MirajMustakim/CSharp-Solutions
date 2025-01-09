/* Define a method named Durum. This method should take two parameters: "height" in meters (e.g., 1.72) and "weight" in kilograms (e.g., 75). Inside the method, calculate the index using the formula index = weight / (height * height) and return the index to the main method. In the main method:

If the index is between 18 and <25, print "Normal".
If the index is between 25 and <30, print "Overweight".
If the index is 30 or higher, print "Obese".
If the index is 35 or higher, print "Severely Obese".

Durum isminde bir metot tanımlayınız. Bu metot "boy"u metre cinsinden (1,72 gibi), "ağırlık"ı kg cinsinden (75 gibi) iki değişkeni parametre olarak alsın. Metot içerisinde indeks = ağırlık / (boy * boy) hesabını yaparak indeks değerini main'e gönderiniz. Main bloğu içerisinde:

İndeks 18 ile <25 arasındaysa normal,
İndeks 25 ile <30 arasındaysa kilolu,
İndeks 30 ve daha yüksekse obez,
İndeks 35 ve daha fazlaysa ciddi obez
olarak ekrana yazdıran C# kodunu yazınız.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your height in meters (e.g., 1.72): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your weight in kilograms (e.g., 75): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        double index = Durum(height, weight);

        if (index < 18)
        {
            Console.WriteLine("Underweight");
        }
        else if (index >= 18 && index < 25)
        {
            Console.WriteLine("Normal");
        }
        else if (index >= 25 && index < 30)
        {
            Console.WriteLine("Overweight");
        }
        else if (index >= 30 && index < 35)
        {
            Console.WriteLine("Obese");
        }
        else
        {
            Console.WriteLine("Severely Obese");
        }
    }

    static double Durum(double height, double weight)
    {
        return weight / (height * height);
    }
}
