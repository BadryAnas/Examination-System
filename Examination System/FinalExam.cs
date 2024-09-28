using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class FinalExam : Exam
    {
        
        public override void ShowExam()
        {

            foreach (object question in QuestionsList)
            {
                int answar;

                if (question is T_F t_f)
                {
                    Console.WriteLine($"{t_f.GetHeader()}\tMark ({t_f.GetMark()})");
                    Console.WriteLine("===========================================");

                    Console.WriteLine($"{t_f.GetBody()} ?");
                    Console.WriteLine("1. True.\n2. False.");
                    Console.WriteLine("-------------------------------------------");

                    int.TryParse(Console.ReadLine(), out answar);
                    t_f.SetAnswar(answar);
                    while (answar != 2 && answar != 1)
                    {
                        int.TryParse(Console.ReadLine(), out answar);
                        t_f.SetAnswar(answar);
                    }

                    if (t_f.IsAnswarTrue())
                    {
                        t_f.SetGrade(t_f.GetMark());
                    }
                }
                else if (question is MCQ mCQ)
                {
                    Console.WriteLine($"{mCQ.GetHeader()}\tMark ({mCQ.GetMark()})");
                    Console.WriteLine("===========================================");

                    Console.WriteLine($"{mCQ.GetBody()} ?");

                    mCQ.GetChoices();


                    //Console.WriteLine( mCQ.GetChoices() );
                    Console.WriteLine("-------------------------------------------");


                    int.TryParse(Console.ReadLine(), out answar);
                    mCQ.SetAnswar(answar);

                    while (answar != 2 && answar != 1)
                    {
                        int.TryParse(Console.ReadLine(), out answar);
                        mCQ.SetAnswar(answar);
                    }

                    if (mCQ.IsAnswarTrue())
                    {
                        mCQ.SetGrade(mCQ.GetMark());
                    }
                }
            }

            Console.Clear();
            int order = 1;
            foreach (Question question in QuestionsList)
            {
                
                Console.WriteLine($"{order}){question.GetBody()} ?");

                if (question is T_F t_f)
                {
                    if (t_f.GetCorrectAnswar() == 2)
                    {
                        Console.WriteLine($"Correct Answar : False.");
                    }
                    else
                    {
                        Console.WriteLine($"Correct Answar : True.");
                    }
                }
                else if (question is MCQ mCQ)
                {
                    mCQ.GetChoices();
                    int index = question.GetCorrectAnswar();

                    Console.WriteLine($"Correct Answar IS Choice number : {mCQ.GetCorrectAnswar()}");
                }
                Console.WriteLine();
                order++;
            }


        }

        
    }
}
