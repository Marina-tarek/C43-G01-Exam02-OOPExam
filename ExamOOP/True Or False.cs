using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP
{
    public class True_Or_False : Question
    {

        public override string ToString()
        {
            return $"{Header}True or False";
        }
        public True_Or_False()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "true");
            Answers[1] = new Answer(2, "false");
        }
        public override void Add()
        {
            int rightAnswer;
            decimal mark;
            bool solve,Input;
            do
            {
                Console.WriteLine("Enter The Qeustion:");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));

            do
            {
                Console.Write("Please enter the right answer 1 for true and 2 for false : ");
                solve = int.TryParse(Console.ReadLine(), out rightAnswer);
            } while (!(solve && rightAnswer is 1 or 2));

            do
            {
                Console.Write("Enter Mark of quesion : ");
                Input = decimal.TryParse(Console.ReadLine(), out mark);
            } while (!Input || mark < 0);

            Mark = mark;
            Console.WriteLine();



        }

    }
}
