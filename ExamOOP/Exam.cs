using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class Exam
    {
        //        a.Time of exam
        //b.Number of Questions
        //c.Show Exam Functionality that its implementations will be
        //different for each exam based on its type.
        public int ExamTime { get; set; }
        public int NumOfQuestions { get; set; }
        public Exam(int examTime,int numOfQuestion)
        {
            ExamTime=examTime;
            NumOfQuestions=numOfQuestion;
        }
    }
}
