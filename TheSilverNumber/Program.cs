using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSilverNumber
{
	class Program
	{
		static void Main(string[] args) {
			int target = 3;
			int[] numbersToBeUsed = { 1, 2, 3, 4, 7, 13, 15, 22, 3, 4, 7 };
		
			AlogrithmTwo algoToSolveWith = new AlogrithmTwo(numbersToBeUsed, target);
			algoToSolveWith.FindTheSolution();

			Console.ReadLine();
		}
	}
}
