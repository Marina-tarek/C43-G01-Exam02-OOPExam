
namespace ExamOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Subject subject = new Subject(1,"m");
            subject.CreateExam();

            Console.ReadKey();
        }
    }
}
