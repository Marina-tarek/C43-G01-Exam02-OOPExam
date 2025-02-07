using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamOOP
{
    public class Subject(int id, string name)
    {
        //a.Subject Id.
        //b.Subject Name.
        //c.Exam of the subject.
        //d.We need to implement functionality to create the exam of
        //the subject.
        public int Id { get; set; } = id;
        public string? Name { get; set; } = name;
        public Exam Exam { get; set; }
        public void  CreateExam() 
        {
            char Texam;
            int examTime,Qnum;
            
            bool questionNum,Time, TypeOfExam;
            do
            {

                Console.Write("please enter P for practicalExam Or F for finalExam : ");
                TypeOfExam = char.TryParse(Console.ReadLine(), out Texam);

            }
            while (!(TypeOfExam) || !(char.ToLower(Texam) == 'p' || char.ToLower(Texam) == 'f'));
            do
            {

                Console.Write("please enter Time of the exam from 30 to 120 min : ");
                Time = int.TryParse(Console.ReadLine(),out examTime);
               
            }
            while (!Time ||  (examTime<30) || (examTime > 120));


            if (char.ToLower(Texam) == 'p')
            {
                do
                {
                    Console.Write("In practicalExam Please Enter The Number Of Questions 1-5  : ");
                    questionNum = int.TryParse(Console.ReadLine(), out Qnum);
                    Exam = new PracticalExam(examTime, Qnum);
                    Exam.Add();
                    
                }
                while (!questionNum || (Qnum > 5) || (Qnum < 1));
                Console.Clear();
            }
            else if (char.ToLower(Texam) == 'f')
            {
                do
                {
                    Console.Write("In FinalExam Please Enter The Number Of Questions 4-20  : ");
                    questionNum = int.TryParse(Console.ReadLine(), out Qnum);

                    Exam = new FinalExam(examTime,Qnum);
                    Exam.Add();

                }
                while (!questionNum && (Qnum > 20) && (Qnum < 4));
            }

            Console.Clear();


        }
    }
}
