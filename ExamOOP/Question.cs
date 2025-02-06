using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class Question
    {
        //properties
        public string Header { get; set; }
        public string Body { get; set; }
        public double Mark { get; set; }
        //public Answers[] AnswerList { get; set; }

        //constructor
        public Question(string header, string body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            
        }
        //method
        public override string ToString()
        {
            return $"{Header}\n{Body}\n{Mark}";
        }
    }
}
