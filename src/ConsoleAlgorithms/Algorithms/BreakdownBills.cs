using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAlgorithms.Algorithms
{
    public class BreakdownBills
    {
		public static List<string> GetDetails(long amount)
		{
			var msgs = new List<string>();
			var denominations = new List<int> { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 };
            
			for (int i = 0; i < denominations.Count; i++)
            {
                if (amount > 0)
                {
					var rest = amount / denominations[i];

					if (rest > 0)
                    {
						msgs.Add($"{rest} x {denominations[i]} = {rest * denominations[i]}");
						amount = amount - rest * denominations[i];
					}
				}
			}

			return msgs;
		}

		public static void Print(long input)
		{
			Console.WriteLine("**** BreakdownBills: ");
			var msgs = GetDetails(input);

			foreach (var element in msgs)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine();
		}
	}
}
