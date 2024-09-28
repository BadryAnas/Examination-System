using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            foreach (T_F question in QuestionsList)
            {
                Console.WriteLine($"{question.GetHeader()}\tMark ({question.GetMark()})");
                Console.WriteLine("===========================================");

                Console.WriteLine(question.GetBody());
                Console.WriteLine("1. True.\n2. Flase.");
                Console.WriteLine("-------------------------------------------");

                int answar;
                int.TryParse(Console.ReadLine(), out answar);
                question.SetAnswar(answar);
                while(answar != 2 && answar != 1)
                {
                    int.TryParse(Console.ReadLine(), out answar);
                    question.SetAnswar(answar);
                }
                if (question.IsAnswarTrue())
                {
                    question.SetGrade(question.GetMark());
                }
            }


            Console.Clear();
            int order = 1;
            foreach (T_F question in QuestionsList)
            {
                
                Console.WriteLine($"{order}){question.GetBody()} ?");

                if (question.GetCorrectAnswar() == 2)
                {
                    Console.WriteLine($"Correct Answar : False.");
                }
                else
                {
                    Console.WriteLine($"Correct Answar : True.");
                }
                Console.WriteLine();

                order++;
            }

        }
    }
}
