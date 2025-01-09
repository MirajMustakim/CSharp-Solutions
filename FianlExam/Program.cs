namespace FianlExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the midterm grade : ");
            double midtermGrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the final term grade : ");
            double finalGrade = Convert.ToDouble(Console.ReadLine());

            CalculateEndOfTermGrade(midtermGrade,finalGrade);

        }

        static void CalculateEndOfTermGrade(double midtermGrade,double finalGrade)
        {
            double endOfTermGrade = 0.4 * midtermGrade + 0.6 * finalGrade;

            if (endOfTermGrade >= 90)
            {
                Console.WriteLine("Successful");
            }
            else if (endOfTermGrade >= 60)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
