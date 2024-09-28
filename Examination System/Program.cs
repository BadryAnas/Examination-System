using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject sub01 = new Subject(10, "C#");
            sub01.CreateExam();
            Console.Clear();

            Console.WriteLine("Do you want to start the exam (Y | N)");

            if(char.Parse(Console.ReadLine()) == 'Y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                sub01.exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");
                Console.WriteLine($"Your Total grade is : {sub01.exam.GetTotalGrade()}"); 
            }

        }
    }
}
