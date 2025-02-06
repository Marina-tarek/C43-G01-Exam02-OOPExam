using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamOOP
{
    internal class Subject
    {
        //a.Subject Id.
        //b.Subject Name.
        //c.Exam of the subject.
        //d.We need to implement functionality to create the exam of
        //the subject.
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Exam { get; set; }
        public void  CreateExam() 
        {
            //Every Exam object is Associated to a Subject.
            int examTime, numOfQuestion;
            string TypeOfExam;
            Console.Write("please enter P for practicalExam Or F for finalExam");
            TypeOfExam = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(TypeOfExam))
            {
                Console.Write("please enter P for practicalExam Or F for finalExam");
                return;
               
            }
            else 
            {
                if (TypeOfExam == "p" || TypeOfExam == "f")
                {
                    Console.WriteLine(TypeOfExam);
                }else
                {
                    Console.WriteLine("Must enter p or f");
                    Console.Write("please enter P for practicalExam Or F for finalExam");
                }
            }
        }
    }
}
