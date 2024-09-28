using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class MCQ : Question
    {
        const int NUMBER_OF_CHOICES = 3;

        Answars[] choices;

        public MCQ()
        {
            header = "Choose one answar Question";
            choices = new Answars[NUMBER_OF_CHOICES];
        }

        public void SetChoices()
        {
            Console.WriteLine("Please, Enter The Choices");

            for (int i = 0; i < NUMBER_OF_CHOICES; i++)
            {
                string choice;
                do
                {
                    Console.WriteLine($"please Enter Choice number {i + 1}");
                    choice = Console.ReadLine();
                    choices[i] = new Answars();
                    choices[i].Answar = choice;
                    choices[i].Id = i + 1;

                } while (string.IsNullOrEmpty(choice));
            }
        }

        public void GetChoices()
        {
            for (int i = 0; i < NUMBER_OF_CHOICES; i++)
            {
                Console.WriteLine($"{i+1}) {choices[i].Answar}");
            }
        }


        public int GetNumberOfChoices() { return NUMBER_OF_CHOICES; }

        public override void SetAnswar(int _answar)
        {
            if (_answar != 1 && _answar != 2 && _answar != 3)
            {
                Console.WriteLine("it's Invalid answar");
            }
            else
            {
                selectedAnswar = _answar;
            }
        }



        public override void SetCorrectAnswar()
        {
            int rightAnswar;
            do
            {
                Console.WriteLine("Please, Enter The Right Answar for Question");
                int.TryParse(Console.ReadLine(), out rightAnswar);

                if (rightAnswar != 1 && rightAnswar != 2 && rightAnswar != 3)
                {
                    Console.WriteLine("it's Invalid answar");
                }

            } while (rightAnswar != 1 && rightAnswar != 2 && rightAnswar != 3);

            correctAnswar = rightAnswar;
       
        }

       
    }
}
