﻿using System;
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
            int examTime,Qnum, numOfQuestion=default;
            string TypeOfExam;
            bool questionNum,Time;
            do
            {

                Console.Write("please enter P for practicalExam Or F for finalExam : ");
                TypeOfExam = Console.ReadLine().ToLower();

            }
            while (string.IsNullOrEmpty(TypeOfExam)||!(TypeOfExam == "p" || TypeOfExam == "f"));
            do
            {

                Console.Write("please enter Time of the exam from 30 to 120 min : ");
                Time = int.TryParse(Console.ReadLine(),out examTime);
               
            }
            while (!Time ||  (examTime<30) || (examTime > 120));


            if (TypeOfExam == "p")
            {
                do
                {
                    Console.Write("In practicalExam Please Enter The Number Of Questions 1-5  : ");
                    questionNum = int.TryParse(Console.ReadLine(), out Qnum);
                    Exam = new PracticalExam(examTime, numOfQuestion);
                    Exam.Add();

                }
                while (!questionNum || (Qnum > 5) || (Qnum < 1));
            }
            else if (TypeOfExam == "f")
            {
                do
                {
                    Console.Write("In FinalExam Please Enter The Number Of Questions 10-20  : ");
                    questionNum = int.TryParse(Console.ReadLine(), out Qnum);

                    Exam = new FinalExam(examTime,numOfQuestion);
                    Exam.Add();

                }
                while (!questionNum || (Qnum > 20) || (Qnum < 10));
            }

            Console.Clear();


        }
    }
}
