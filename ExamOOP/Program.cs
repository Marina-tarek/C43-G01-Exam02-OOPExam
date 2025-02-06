
namespace ExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question("Solve Question", "2+3?", 5);
            Console.WriteLine(q1);

            Subject subject = new Subject();
            subject.CreateExam();

            Console.ReadKey();  
        }
    }
}
