using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAlgorithms.Algorithms
{
    public class Fibonacci
    {
		public static List<long> GetSequence(long quantity)
		{
			var serie = new List<long>();
			var current = 1L;
			var prev = 0L;

			if (quantity <= 0)
			{
				throw new Exception("Quantity must be gratter than 0");
			}
			else
			{
				serie.Add(0);

				if (quantity > 1)
				{
					long next;
					serie.Add(1);

					for (int i = 2; i < quantity; i++)
					{
						next = current + prev;
						prev = current;
						current = next;
						serie.Add(next);
					}
				}
			}

			return serie;
		}

		public static void Print(long input)
		{
			Console.WriteLine("**** Fibonacci: ");
			var fibo = GetSequence(input);

			foreach (var element in fibo)
			{
				Console.WriteLine(element);
			}

			Console.WriteLine();
		}
	}
}
