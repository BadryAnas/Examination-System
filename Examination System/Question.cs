using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public abstract class Question
    {
        protected int correctAnswar;
        protected int selectedAnswar;
        protected string header;
        string body;
        int mark;
        int grade;
        
        // Constructor

        public Question()
        {
            header = string.Empty;
            body = string.Empty;
            mark = 0;
            grade = 0;
        }

        // Getters

        public string GetBody() { return body; }
        public int GetMark() { return mark; }
        public string GetHeader() { return header; }
        public int GetAnswar() { return selectedAnswar; }
        public int GetCorrectAnswar() { return correctAnswar; }
        public  bool IsAnswarTrue()  { return (selectedAnswar == correctAnswar); }
        public int GetGrade() { return grade; }
        
        // Setters

        public void SetBody()
        {
            string bodyOfQuestion;

            do
            {
                Console.WriteLine("Please, Enter The Body of Question");
                bodyOfQuestion = Console.ReadLine();
            } while (string.IsNullOrEmpty(bodyOfQuestion));

            this.body = bodyOfQuestion;
        }
        public void SetMark()
        {
            int mark;
            do
            {
                Console.WriteLine("Please, Enter The Mark of Question");
                int.TryParse((Console.ReadLine()), out mark);

            } while (mark < 1);

            this.mark = mark; 
        }
        public void SetGrade(int mark) { grade = mark; }



        // Abstract
        public abstract void SetAnswar(int _answar);
        public abstract void SetCorrectAnswar();

    }

}
