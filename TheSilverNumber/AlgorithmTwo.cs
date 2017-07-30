using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSilverNumber
{
	public class AlogrithmTwo
	{
		private int[] numberList;
		private int targetNumber;

		AlogrithmTwo(int[] numbs, int target) {
			numberList = numbs;
			targetNumber = target;
		}

		public void FindTheSolution() {
			int[] solutionArray = { };
			int currentPositionSolution = 0;


			for (int j = 0; j < solutionArray.Length; j++) {
				int tempstore;
				tempstore = numberList[j];
				for (int i = j + 1; i < numberList.Length; i++) {
					solutionArray[j] = numberList[i];
					int sum = 0;
					for (int currentPositionProblem = 0; currentPositionProblem < solutionArray.Length; currentPositionProblem++) {
						sum += solutionArray[currentPositionProblem];
						if (sum == targetNumber) {
							//Console.WriteLine("success");
							WriteArray(solutionArray);
						}
					}
				}
				solutionArray[j] = tempstore;
			}
		}

		private void WriteArray(int[] toBeWritten) {
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i <= toBeWritten.Length; i++) {
				builder.Append(" ").Append(toBeWritten[i].ToString()).Append(" ");
			}
			builder.AppendLine();
			Console.WriteLine(builder);
		}
	}
}