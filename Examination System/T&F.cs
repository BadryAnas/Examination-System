using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal class T_F : Question
    {

        public T_F()
        {
            header = "True | False Question";
        }

        public override void SetAnswar(int _answar)
        {
            if (_answar != 1 && _answar != 2)
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
                Console.WriteLine("Please, Enter The Right Answar for Question => (1 for True , 2 for False)");
                int.TryParse(Console.ReadLine(), out rightAnswar);

                if (rightAnswar != 1 && rightAnswar != 2 )
                {
                    Console.WriteLine("it's Invalid answar");
                }

            } while (rightAnswar != 1 && rightAnswar != 2 );

            correctAnswar = rightAnswar;
        }  
    }
}
