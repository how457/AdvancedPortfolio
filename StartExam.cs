using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AdvancedPortfolio_NamYoon
{
    class StartExam
    {
        public static int startExam(ref MultipleChoiceQuestion[] questionArray, int[] questionNumber, int[] wrongQuestion)
        {
            char userAnswer;
            int incorrectCounter = 0;
            int correctCounter = 0;
            int examIndex = -1;
            for (int r = 0; r < questionArray.Length; r++)
            {
                if (questionArray[r] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Question {0}", r + 1);
                    Console.WriteLine();
                    Console.WriteLine("----------------------------");
                    questionArray[r].DisplayQuestions();
                    Console.Write("Your answer (A,B,C,D): ");
                    userAnswer = char.Parse(Console.ReadLine().ToUpper());

                        
                        
                        if (userAnswer != questionArray[r].CorrectChoice)
                    {
                        incorrectCounter += 1;
                        wrongQuestion[r] = 1;
                    }
                    else
                    {
                        correctCounter += 1;
                    }
                }
            }
            Console.WriteLine("You've done all exams.");
            return examIndex;
        }
    }
}
