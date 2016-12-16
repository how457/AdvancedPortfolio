
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AdvancedPortfolio_NamYoon
{
	class QuestionImportExport
	{
		/// <summary>
		/// Checks to see if the file exists
		/// </summary>
		/// <param name="filePath">Location of the file</param>
		/// <returns>True or False</returns>
		public static bool FileExists(string filePath)
		{
			return File.Exists(filePath);
		}



		/// <summary>
		/// Reads a comma separated file of students and adds students to the student array
		/// </summary>
		/// <param name="">array storing students</param>
		/// <param name="filePath">file path to read from</param>
		public static void ReadFile(ref MultipleChoiceQuestion[] questionArray, string filePath)
		{
			//Declare variables
			string recordLine;
			int index;

			//Declare a variable type of StreamReader used to read the file
			StreamReader reader = null;

			try
			{
				//Create an instance of reader with the fileName passed in as the stream
				reader = new StreamReader(filePath);

				//Read file until there are no more records
				while ((recordLine = reader.ReadLine()) != null)
				{
					//Declare a string array to hold each field within a record
					string[] fileRecordArray = recordLine.Split(',');

					//Create a new instance of question and pass information from
					//fileRecordArray into the student
					MultipleChoiceQuestion newQuestion = new MultipleChoiceQuestion(
						fileRecordArray[0],
						fileRecordArray[1],
						fileRecordArray[2],
						fileRecordArray[3],
						fileRecordArray[4],
						char.Parse(fileRecordArray[5])

						);

					int count = App.countArrayQuestion(ref questionArray);
					if (count < questionArray.Length)
					{
						index = count + 1;
					}
					else
					{
						index = -1;
					}

					//If array is not full, add the new student
					if (index != -1)
					{
						//Assign the new student created above to the open element
						questionArray[index] = newQuestion;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Could not find a part of the path {0}, {1}",
					filePath, ex.Message);
			}
			finally
			{
				//Close and Dispose will close the StreamReader 
				//and release the recources it was using 

				reader.Close();
				reader.Dispose();
			}

		}



		/// <summary>
		/// Write a comma separated student to file
		/// </summary>
		/// <param name="studentArray">array storing students</param>
		/// <param name="filePath">file path to write to</param>
		public static void WriteFile(ref MultipleChoiceQuestion[] questionArray, string filePath)
		{
			//Declare a variable to type StreamWriter used to write the file
			StreamWriter writer = null;

			try
			{
				writer = new StreamWriter(filePath);

				//loop through the array of students and write the record to the file
				foreach (MultipleChoiceQuestion question in questionArray)
				{
					//Write each student
					writer.WriteLine(question.QuestionCommaSeparatedOutput());
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine("ERROR: {0}", ex.Message);
			}
			finally
			{
				writer.Close();
				writer.Dispose();
			}
		}





	}
}
