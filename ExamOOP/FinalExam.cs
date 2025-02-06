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

        public override void AddQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
