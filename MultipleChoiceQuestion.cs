using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AdvancedPortfolio_NamYoon
{
    public class MultipleChoiceQuestion
    {
        #region Declare
        private string _Question;
        private string _Choice1;
        private string _Choice2;
        private string _Choice3;
        private string _Choice4;
        private char _CorrectChoice;
        #endregion

        #region Properties
        /// <summary>
        /// Represents questions
        /// </summary>
        public string Questions
        {
            get { return _Question; }
            set { _Question = value; }
        }
        /// <summary>
        /// represents choice 1
        /// </summary>
        public string Choice1
        {
            get { return _Choice1; }
            set { _Choice1 = value; }
        }

        /// <summary>
        /// represents choice2
        /// </summary>
        public string Choice2
        {
            get { return _Choice2; }
            set { _Choice2 = value; }
        }

        /// <summary>
        /// Represents choice 3
        /// </summary>
        public string Choice3
        {
            get { return _Choice3; }
            set { _Choice3 = value; }
        }

        /// <summary>
        /// Represents choice 4
        /// </summary>
        public string Choice4
        {
            get { return _Choice4; }
            set { _Choice4 = value; }
        }

        /// <summary>
        /// represents Editing answers
        /// </summary>

        public char CorrectChoice
        {
            get { return _CorrectChoice; }
            set
            {
                if (value != 'A' && value != 'B' && value != 'C' && value != 'D')
                {
                    throw new Exception("Invalid Answer choice, please make choice from A, B, C or D.");
                }
                else
                {
                    _CorrectChoice = value;
                }
            }

        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor, avoids property validation to assign defaults
        /// </summary>
        public MultipleChoiceQuestion()
        {
            _Question = "";
            _Choice1 = "";
            _Choice2 = "";
            _Choice3 = "";
            _Choice4 = "";
            _CorrectChoice = ' ';
        }


        public MultipleChoiceQuestion(string Questions, string Choice1, string Choice2, string Choice3, string Choice4, char CorrectChoice)
        {
            this.Questions = Questions;
            this.Choice1 = Choice1;
            this.Choice2 = Choice2;
            this.Choice3 = Choice3;
            this.Choice4 = Choice4;
            this.CorrectChoice = CorrectChoice;
        }
        #endregion

        /// <summary>
        /// Display Question and choices
        /// </summary>
        public void DisplayQuestions()
        {
            //InputOutput.DisplayTitle("Question {0}");

            Console.WriteLine(Questions);
            Console.WriteLine("A. " + Choice1);
            Console.WriteLine("B. " + Choice2);
            Console.WriteLine("C. " + Choice3);
            Console.WriteLine("D. " + Choice4);
            Console.WriteLine();

        }

        public void DisplayQuestionsEditing(int questionNumber)
        {
            Console.WriteLine("The question is as follows: ");
            InputOutput.DisplayTitle(string.Format("Question {0}",questionNumber+1));
            Console.WriteLine(Questions);
            Console.WriteLine("A. " + Choice1);
            Console.WriteLine("B. " + Choice2);
            Console.WriteLine("C. " + Choice3);
            Console.WriteLine("D. " + Choice4);
        }

        public string QuestionCommaSeparatedOutput()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", Questions, Choice1, Choice2, Choice3, Choice4, CorrectChoice);
        }
    }
}
