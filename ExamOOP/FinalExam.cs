using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class FinalExam : Exam
    {
        public FinalExam(int examTime, int numOfQuestion) : base(examTime, numOfQuestion)
        {
        }

        public override void Add()
        {
            Questions = new Question[NumOfQuestion];
            for (int i = 0; i < Questions.Length; i++)
            {
                int questionType;
                bool flag;

                do
                {
                    Console.Write("Enter Type Of Questions (1 for MCQ and 2 for T(Or)F):");
                    flag = int.TryParse(Console.ReadLine(), out questionType);
                }
                while (!(flag && questionType is 1 or 2));

                if (questionType == 1)
                {
                    Questions[i] = new MCQ();
                    Questions[i].Add();

                }

                else
                {
                    Questions[i] = new True_Or_False();
                    Questions[i].Add();
                }
            }

            Console.Clear();
        }

        public override void ShowExam()
        {
            int Answer;
            bool flag;
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.Write($"Q.{i + 1}:");
                Console.WriteLine(Questions[i].Body);

                for (int k= 0; k < Questions[i].Answers?.Length; k++)
                {
                    Console.WriteLine($"{Questions[i].Answers?[k].AnswerText}");
                }

                Console.WriteLine("-------------------------");


                if (Questions[i].GetType() == typeof(MCQ))
                {
                    do
                    {
                        Console.Write("Enter yor answer (1 or 2 or 3):");
                        flag = int.TryParse(Console.ReadLine(), out Answer);
                    } while (!(flag && Answer is 1 or 2 or 3));

                }

                else
                {
                    do
                    {
                        Console.Write("Enter Your answer 1 for true and 2 for false :");
                        flag = int.TryParse(Console.ReadLine(), out Answer);
                    } while (!(flag && Answer is 1 or 2));
                }

                Questions[i].Response.AnswerId = Answer;
                Questions[i].Response.AnswerText = Questions[i].Answers?[Answer - 1].AnswerText;
                Console.WriteLine("=================================");

            }

            Console.Clear();

            decimal grade = 0; decimal Marks = 0;

            for (int i = 0; i < Questions?.Length; i++)
            {
                Marks += Questions[i].Mark;

                if (Questions[i].Response.AnswerId == Questions[i].RightAnswer.AnswerId)
                    grade += Questions[i].Mark;

                Console.WriteLine($"Q{i + 1}.{Questions[i].Body}\t\t({Questions[i].Mark} Marks)");
                Console.WriteLine($"Your Answer=>{Questions[i].Response.AnswerText}");
                Console.WriteLine($"Right Answer=>{Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine("=================================");
            }

            Console.WriteLine($"Your grade is {grade}/{Marks} Marks");
        }
    }
}
