using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    internal class MCQ : Question
    {

        public override string ToString()
        {
            return $"{Header}MCQ Question";
        }
        public MCQ() 
        {
            Answers = new Answer[3];
        }
        public override void Add()
        {
            do
            {
                Console.WriteLine("Enter The Qeustion:");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));

        }

    }
}
