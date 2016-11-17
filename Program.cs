using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            MCQ mcq = new MCQ();
            foreach(Question question in mcq.createQuestions())
            {
                Console.Write(question.QID + "\t");
                Console.WriteLine(question.QText);
                Console.WriteLine("*****************************");
                foreach(Answer answer in question.AnswerList)
                {
                    Console.Write(answer.AnswerId + "\t");
                    Console.WriteLine(answer.AnswerText);
                }
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
        }
    }
}
