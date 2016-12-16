using System;
namespace CPSC1012_AdvancedPortfolio_NamYoon
{
	public class App
	{
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
						break;
					case 2:
						break;
					// 345...
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

		public static int GetNextArrayIndex(ref MultipleChoiceQuestion[] questionArray)
		{
			throw new NotImplementedException();
		}
	}
}