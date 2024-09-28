using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Exam
    {
        protected ArrayList QuestionsList = new ArrayList();
        int timeOfExamInMinutes;
        int numberOfQuestions;

        int totalGrades = 0;

        // Setters

        public void SetTimeOfExamInMinutes()
        {
            int time;
            do
            {
                Console.WriteLine("Please, Enter The Time of Exam in Minutes");
                int.TryParse(Console.ReadLine(), out time);
            } while (time < 1);

            timeOfExamInMinutes = time; 
        }
        public void SetNumberOfQuestions() 
        {
            int _numberOfQuestions;
            do
            {
                Console.WriteLine("Please, Enter number Of Questions");
                int.TryParse(Console.ReadLine(), out _numberOfQuestions);

            } while (_numberOfQuestions < 1);

            numberOfQuestions = _numberOfQuestions;
        }
        public void AddQuestion(Question question) { QuestionsList.Add(question); }
        

        // Getters

        public int GetNumberOfQuestions() { return numberOfQuestions; }
        public int GetTimeOfExamInMinutes() {  return timeOfExamInMinutes; }
        public int GetTotalGrade() 
        {
            foreach (Question question in QuestionsList)
            {
                totalGrades += question.GetGrade();
            }
            return totalGrades;
        }



        public abstract void ShowExam();

    }
}
