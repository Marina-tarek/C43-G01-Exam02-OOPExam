using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class Exam
    {
        // a.Time of exam
        //b.Number of Questions
        //c.Show Exam Functionality that its implementations will be
        //different for each exam based on its type.
        public int ExamTime { get; set; }
        public int NumOfQuestion { get; set; }
        public Question[] Questions { get; set; }
        //
        public Exam(int examTime, int numOfQuestion)
        {
            ExamTime = examTime;
            NumOfQuestion = numOfQuestion;
        }

        public abstract void ShowExam();
        public abstract void Add();
    }
}
