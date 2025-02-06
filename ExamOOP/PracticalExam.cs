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
        public override void AddQuestion()
        {
            //MCQ mcq = new MCQ();
        }
    }
}
