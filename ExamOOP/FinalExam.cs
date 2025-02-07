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

                for (int j = 0; j < Questions[i].Answers.Length; j++)
                {
                    Console.WriteLine($"{Questions[i].Answers[j].Text}");
                }

                Console.WriteLine("-------------------------");


                if (Questions[i].GetType() == typeof(Mcq))
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

                Questions[i].Response.Id = Answer;
                Questions[i].Response.Text = Questions[i].Answers[Answer - 1].Text;
                Console.WriteLine("=================================");

            }

            Console.Clear();

            decimal grade = 0; decimal Marks = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                Marks += Questions[i].Mark;

                if (Questions[i].Response.Id == Questions[i].RightAnswer.Id)
                    grade += Questions[i].Mark;

                Console.WriteLine($"Q{i + 1}.{Questions[i].Body}\t\t({Questions[i].Mark} Marks)");
                Console.WriteLine($"Your Answer=>{Questions[i].Response.Text}");
                Console.WriteLine($"Right Answer=>{Questions[i].RightAnswer.Text}");
                Console.WriteLine("=================================");
            }

            Console.WriteLine($"Your grade is {grade}/{Marks} Marks");
        }
    }
}
}
