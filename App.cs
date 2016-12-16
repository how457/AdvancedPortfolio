using System;
namespace CPSC1012_AdvancedPortfolio_NamYoon
{
	public class App
	{
		MultipleChoiceQuestion[] questionArray = new MultipleChoiceQuestion[30];

		public App() { }

		public void start()
		{
			int menuChoice;

			do
			{
				menuChoice = GetMainInput();
				switch (menuChoice)
				{
					case 1:
						CreateQuestion();
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						break;
					case 7:
						break;
					case 8:
						break;

					default:
						break;
				}
			} while (menuChoice != 0);

		}

		public int GetMainInput()
		{
			InputOutput.DisplayTitle("Multiple Choice Exam");
			Console.WriteLine("Please Enter: ");
			Console.WriteLine("1 - to create a new question");
			Console.WriteLine("2 - to display all questions,");
			Console.WriteLine("3 - to edit question,");
			Console.WriteLine("4 - to delete question,");
			Console.WriteLine("5 - import question from a file,");
			Console.WriteLine("6 - export questions to a file,");
			Console.WriteLine("7 - start the exam,");
			Console.WriteLine("8 - mark the exam,");
			Console.WriteLine("0 - exit the program.");
			Console.WriteLine("\nOption?");

			String userInput = Console.ReadLine();
			int userInputInt = int.Parse(userInput);
			return userInputInt;
		}

		public void CreateQuestion()
		{
			InputOutput.DisplayTitle("Multiple Choice Exam - New Question");
			Console.WriteLine("\nThere are currently {0} questions in the exam.", countArrayQuestion(ref questionArray));

			Console.WriteLine("\nEnter the question");


		}

		public int MarkExam() 
		{
			
		}

		public static int countArrayQuestion(ref MultipleChoiceQuestion[] questionArray)
		{
			for (int i = 0; i < questionArray.Length; i++)
			{
				if (questionArray[i] == null)
				{
					return i;
				}
				if (i == questionArray.Length - 1)
				{
					return i + 1;
				}
			}
			return -1;
		}
	}
}