
using System.Diagnostics;

namespace ExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject subject = new Subject(1,"m");
            subject.CreateExam();
            Console.Clear();

            char yn;
            bool YNInput;
            do
            {
                Console.Write("Do You Want To Start Exam : Press (Y for Yes and N for No):");
                YNInput = char.TryParse(Console.ReadLine(), out yn);

            } while (!(YNInput && char.ToLower(yn) == 'y' || char.ToLower(yn) == 'n'));

            if (yn == 'y')
            {
                Console.Clear();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject.Exam.ShowExam();

                Console.WriteLine($"The ELpased Time:{stopwatch.Elapsed}");

            }


            Console.ReadKey();
        }
    }
}
