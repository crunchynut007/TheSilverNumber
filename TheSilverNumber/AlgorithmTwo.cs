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

		public AlogrithmTwo(int[] numbs, int target) {
			numberList = numbs;
			targetNumber = target;
		}

		public void FindTheSolution() {
			int[] solutionArray = new int[numberList.Length];
			for (int j = 0; j < solutionArray.Length; j++) {
				int tempstore;
				tempstore = numberList[j];
				if (j == 0) {
					solutionArray[j] = numberList[j];
					if (solutionArray[j] == targetNumber) {
						WriteArray(solutionArray);
					}
				}
				bool first = false;
				bool Last = false;
				for (int i = j ; i < numberList.Length; ) {
					i++;
					if (i == 1) {
						first = true;
					}
					else if (i == numberList.Length) {
						Last = true;
					}
					if (first == true) { solutionArray[j] = numberList[0]; }
					else if (Last == true) { solutionArray[j] = numberList[i-1]; }
					else { solutionArray[j] = numberList[i]; }
					int sum = 0;
					/*requires another summation loop to iterate through all combinations of existing array elements in solutionarray
					* by removing existing elements to check for validity. Need to iterate through previous elemetns from any current
					* element.
					*/
					for (int currentPositionProblem = 0; currentPositionProblem < solutionArray.Length; currentPositionProblem++) {
						sum += solutionArray[currentPositionProblem];
						/*if (sum == targetNumber) {
							WriteArray(solutionArray);
						}*/
					}
					if (sum == targetNumber) {
						WriteArray(solutionArray);
					}
				}
				solutionArray[j] = tempstore;
			}
		}

		private void WriteArray(int[] toBeWritten) {
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < toBeWritten.Length; i++) {
				if (toBeWritten[i] != 0) {
					builder.Append(" ").Append(toBeWritten[i].ToString()).Append(" ");
				}
			}
			builder.AppendLine();
			Console.WriteLine(builder.ToString());
			builder.Clear();
		}
	}
}