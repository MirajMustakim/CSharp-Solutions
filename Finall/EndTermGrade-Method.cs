/* A student's end of term grade status,  it is calculated by taking 40% of the midterm exam and 60% of the final exam. Taking the midterm and final grade as a parameters and the end of term grade;
90 and above is Successful
if 60 and above, Pass
If less than 60, Fail
Write a Method that points */

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
