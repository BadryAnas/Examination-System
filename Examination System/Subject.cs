using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
  
    internal class Subject
    {
        int id;
        string name;
        public Exam exam;
        
        public Subject(int _id , string _name) 
        { 
            id = _id ;
            name = _name ;
        }

        private void ContentOfQuestion(Question question)
        {
            Console.WriteLine(question.GetHeader());
            question.SetBody();
            question.SetMark();
            if(question is MCQ mCQ)
            {
                mCQ.SetChoices();
            }
            question.SetCorrectAnswar();
            exam.AddQuestion(question);
            
        }

        private void ExamInfo()
        {
            exam.SetNumberOfQuestions();
            exam.SetTimeOfExamInMinutes();
        }

        public void CreateExam()
        {
            int numberOfQuestions, time;

            int typeOfExam;
            do
            {
                Console.WriteLine("Please, Enter type of exam ( 1. for Final Exam 2. for Practical Exam )");
                int.TryParse(Console.ReadLine(), out typeOfExam);

            } while (typeOfExam != 1 && typeOfExam != 2);


            if (typeOfExam == 1)
            {
                exam = new FinalExam();
                ExamInfo();

                for (int i = 0; i < exam.GetNumberOfQuestions(); i++)
                {
                    int type;
                    do
                    {
                        Console.WriteLine($"Please, Enter Type of Question {i+1}  ==> (1. For True Or False || 2. For MCQ )");
                        int.TryParse(Console.ReadLine(), out type);

                    } while (type != 1 && type != 2);

                    if (type == 1)
                    {
                        T_F question = new T_F();
                        ContentOfQuestion(question);
                    }
                    else
                    {
                        MCQ question = new MCQ();
                        ContentOfQuestion(question);
                    }
                }
            }
            else
            {
                exam = new PracticalExam();
                ExamInfo();
                for (int i = 0; i < exam.GetNumberOfQuestions(); i++)
                {
                    T_F question = new T_F();
                    ContentOfQuestion(question);
                }
            }
        }
    }
}
