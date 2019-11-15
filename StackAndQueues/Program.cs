using System;
using System.Collections.Generic;

namespace ReverseString
{
	class Program
	{
		static void Main(string[] args)
		{

			var inputFromConsole = Console.ReadLine();

			Stack<char> stack = new Stack<char>();

			foreach (var letter in inputFromConsole)
			{
				stack.Push(letter);
			}

			var iterations = stack.Count;

			for (int i = 0; i < iterations; i++)
			{
				Console.Write(stack.Pop());
			}
			
		}
	}
}
