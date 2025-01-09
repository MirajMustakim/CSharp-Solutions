/* Define a void method named Karar. The method should take four parameters: quiz1_score, midterm_score, quiz2_score, and final_score. If the final result is above 60, print "PASSED"; otherwise, print "FAILED".
   Calculation formula: 
   midterm_score=(quiz1_score∗0.2)+(midterm_score∗0.8)
   final_score=(quiz2_score∗0.2)+(final_score∗0.8)
   result=(midterm_score∗0.4)+(final_score∗0.6)

   Karar isminde bir void metot tanımlayınız. Öğrencilerin quiz1_notu, vize_notu, quiz2_notu ve final_notu şeklinde dört adet parametresi olsun ve sonuca 60’ın üzeri not almışsa GEÇTİ, 60’ın altında bir puan almışsa BÜTE KALDI yazdıran metodu C# dilinde yazınız.
   Hesaplama formülü:
    vize_notu=(quiz1_notu∗0.2)+(vize_notu∗0.8)
    final_notu=(quiz2_notu∗0.2)+(final_notu∗0.8)
    sonuc =(vize_notu∗0.4)+(final_notu∗0.6)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Quiz 1 Score: ");
        double quiz1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Midterm Score: ");
        double midterm = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quiz 2 Score: ");
        double quiz2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Final Exam Score: ");
        double final = Convert.ToDouble(Console.ReadLine());

        Karar(quiz1, midterm, quiz2, final);
    }

    static void Karar(double quiz1, double midterm, double quiz2, double final)
    {
        double midtermScore = (quiz1 * 0.2) + (midterm * 0.8);
        double finalScore = (quiz2 * 0.2) + (final * 0.8);
        double result = (midtermScore * 0.4) + (finalScore * 0.6);

        if (result > 60)
        {
            Console.WriteLine("PASSED");
        }
        else
        {
            Console.WriteLine("FAILED");
        }
    }
}
