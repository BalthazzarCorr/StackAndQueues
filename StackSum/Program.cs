using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputCommands = Console.ReadLine();

			var initalDigits = inputCommands.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

			Stack<int> sumStack = new Stack<int>();

			foreach (var initalDigit in initalDigits)
			{
				sumStack.Push(int.Parse(initalDigit));
			}

			


			while (inputCommands.ToLower() != "end")
			{

				inputCommands = Console.ReadLine();

				string[] inputArr = inputCommands.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				switch (inputArr[0].ToLower())
				{
					case "add":
						sumStack.Push(int.Parse(inputArr[1]));
						sumStack.Push(int.Parse(inputArr[2]));

						break;
					case "remove":
						if (int.Parse(inputArr[1]) < sumStack.Count)
						{
							for (int i = 0; i < int.Parse(inputArr[1]); i++)
							{
							
								sumStack.Pop();
							
							}
						}
						
						break;

				}


				

			}

			var stackCount = sumStack.Count;

			var resultSum = 0;

			for (int i = 0; i < stackCount; i++)
			{
				resultSum += sumStack.Peek();
				sumStack.Pop();

			}
			Console.WriteLine($"Sum: {resultSum}");
		}
	}
}
