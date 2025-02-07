using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int examTime, int numOfQuestion) : base(examTime, numOfQuestion)
        {
        }
        public override void Add()
        {
            Questions = new Question[NumOfQuestion];
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQ();
                Questions[i].Add();

            }


        }
        public override void ShowExam()
        {
            int userAnswer;
            bool flag;

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.Write($"Q.{i + 1}:");
                Console.WriteLine(Questions[i].Body);
                for (int k = 0; k < Questions[i].Answers?.Length; k++)
                {
                    Console.WriteLine(Questions[i].Answers?[k].AnswerText);
                }
                

                do
                {
                    Console.Write("Enter your answer:(1 or 2 or 3):");
                    flag = int.TryParse(Console.ReadLine(), out userAnswer);
                } while (!(flag && userAnswer is 1 or 2 or 3));


                Questions[i].Response.AnswerId = userAnswer;
                Questions[i].Response.AnswerText = Questions[i].Answers?[userAnswer - 1].AnswerText;

                

            }
            Console.Clear();
            Console.WriteLine("The Right Answers");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q.{i + 1}:{Questions[i].Body}=>{Questions[i].RightAnswer.AnswerText}");
                Console.WriteLine("================================");
            }
            decimal grade = 0, totalMarks = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                totalMarks += Questions[i].Mark;

                if (Questions[i].Response.AnswerId == Questions[i].RightAnswer.AnswerId)
                    grade += Questions[i].Mark;
            }

            Console.WriteLine("================================");

            Console.WriteLine($"Your grade is {grade} from {totalMarks} Marks");
        }
    }
}

