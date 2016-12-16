//Author: Ryan Tarnowski
//Date: 10-24-2016
//Purpose: Various methods for valid input and output
//Version: v1.1
    //Added regions to organize code
    //Added GetValidDouble with min and max

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AdvancedPortfolio_NamYoon
{
    class InputOutput
    {
        #region "Strings"

        /// <summary>
        /// Display formatted title.
        /// </summary>
        /// <param name="title">Name of the program or menu</param>
        public static void DisplayTitle(string title)
        {
            Console.WriteLine(title);

            for (int i = 0; i < title.Length + 8; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }
        #endregion

        #region "Integers"
        /// <summary>
        /// Prompt user for a valid integer.
        /// </summary>
        /// <param name="prompt">Message to the user</param>
        /// <returns>Valid Integer</returns>
        public static int GetValidInteger(string prompt)
        {
            int value;
            bool inputIsValid = false;

            //Loop until the user provides a valid integer
            do
            {
                Console.Write(prompt + ": ");

                if (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Error: Not a valid integer.");
                }
                else
                {
                    inputIsValid = true;
                }

            } while (!inputIsValid);

            //Return valid integer
            return value;
        }

        /// <summary>
        /// Prompt user for a valid integer between specified range.
        /// </summary>
        /// <param name="prompt">Message to the user</param>
        /// <param name="min">Min range inclusive</param>
        /// <param name="max">Max range inclusive</param>
        /// <returns>Valid Integer</returns>
        public static int GetValidInteger(string prompt, int min, int max)
        {
            int value;
            bool inputIsValid = false;

            //Loop until the user provides a valid integer
            do
            {
                Console.Write(prompt + " [Between {0} and {1} inclusive]: ", min, max);

                if (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
                {
                    Console.WriteLine("Error: Not a valid integer between {0} and {1}.", min, max);
                }
                else
                {
                    inputIsValid = true;
                }

            } while (!inputIsValid);

            //Return valid integer
            return value;
        }

        /// <summary>
        /// Prompt user for a valid integer greater than or equal to min.
        /// </summary>
        /// <param name="prompt">Message to the user</param>
        /// <param name="min">Min range inclusive</param>
        /// <returns>Returns valid integer</returns>
        public static int GetValidInteger(string prompt, int min)
        {
            int value;
            bool inputIsValid = false;

            //Loop until the user provides a valid integer
            do
            {
                Console.Write(prompt + " [Greater than or equal to {0}]: ", min);

                if (!int.TryParse(Console.ReadLine(), out value) || value < min)
                {
                    Console.WriteLine("Error: Not a valid integer great than or equal to {0}.", min);
                }
                else
                {
                    inputIsValid = true;
                }

            } while (!inputIsValid);

            //Return valid integer
            return value;
        }

        #endregion

        #region "Doubles"

        /// <summary>
        /// Prompt user for a valid double
        /// </summary>
        /// <param name="prompt">Message to the user</param>
        /// <returns>Valid Double</returns>
        public static double GetValidDouble(string prompt)
        {
            double value;
            bool inputIsValid = false;

            //Loop until the user provides a valid double
            do
            {
                Console.Write(prompt + ": ");

                if (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Error: Not a valid double.");
                }
                else
                {
                    inputIsValid = true;
                }

            } while (!inputIsValid);

            //Return valid double
            return value;
        }


        /// <summary>
        /// Prompt user for a valid double between specified range.
        /// </summary>
        /// <param name="prompt">Message to the user</param>
        /// <param name="min">Min range inclusive</param>
        /// <param name="max">Max range inclusive</param>
        /// <returns>Valid Double</returns>
        public static double GetValidDouble(string prompt, double min, double max)
        {
            double value;
            bool inputIsValid = false;

            //Loop until the user provides a valid integer
            do
            {
                Console.Write(prompt + " [Between {0} and {1} inclusive]: ", min, max);

                if (!double.TryParse(Console.ReadLine(), out value) || value < min || value > max)
                {
                    Console.WriteLine("Error: Not a valid double between {0} and {1}.", min, max);
                }
                else
                {
                    inputIsValid = true;
                }

            } while (!inputIsValid);

            //Return valid double
            return value;
        }
        #endregion

        #region "Chars"
    
        /// <summary>
        /// Prompt user for a Yes or No choice
        /// </summary>
        /// <param name="yesAction">Result of the yes selection</param>
        /// <param name="noAction">Result of the no selection</param>
        /// <returns>Returns either Y or N</returns>
        public static char GetYesOrNo(string yesAction, string noAction)
        {
            char value;
            bool inputIsValid = false;

            do
            {
                Console.WriteLine("Enter 'Y' to {0} or 'N' to {1}", yesAction, noAction);

                if (!char.TryParse(Console.ReadLine().ToUpper(), out value))
                {
                    Console.WriteLine("Error: Not a valid choice.");
                }
                else
                {
                    if (value == 'Y' || value == 'N')
                    {
                        inputIsValid = true;
                    }
                }

            } while (!inputIsValid);


            return value;
        }
        #endregion

    }
}
