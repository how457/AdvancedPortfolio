using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AdvancedPortfolio_NamYoon
{
    class MarkExam
    {
        public static void markExam (ref MultipleChoiceQuestion[] questionArray, int[] questionNumber, int[] wrongQuestion, int correctCounter, int incorrectCounter)
        {
            double currentMark = 0;

            currentMark = (correctCounter / questionNumber[0]) * 100;
            if(currentMark > 83)
            {
                Console.WriteLine("You got 100%. You got {0} questions correct out of {1}.", correctCounter, questionNumber[0]);
                Console.WriteLine("You passed the exam");
            }
            else
            {
                Console.WriteLine("You got {0:0.00}%. You got {1} questions correct out of {2}", currentMark, correctCounter, questionNumber[0]);
            }
            
        }
    }
}
