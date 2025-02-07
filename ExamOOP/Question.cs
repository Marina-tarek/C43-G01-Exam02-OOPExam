using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public abstract class Question
    {


        //properties
        public virtual string Header { get; set; }
        public string Body { get; set; }
        public decimal Mark { get; set; }

        public Answer[]? Answers { get; set; }
        public Answer Response { get; set; } = new Answer();
        public Answer RightAnswer { get; set; } = new Answer();
        ////constructor
        //public Question(string header, string body, double mark)
        //{
        //    Header = header;
        //    Body = body;
        //    Mark = mark;

        //}
        ////method
        //public override string ToString()
        //{
        //    return $"{Header}\n{Body}\n{Mark}";
        //}
        public abstract void Add();


    }
}
