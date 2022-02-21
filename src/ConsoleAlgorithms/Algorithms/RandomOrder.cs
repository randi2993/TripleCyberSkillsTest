using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAlgorithms.Algorithms
{
    public class RandomOrder
    {
        public static List<int> GetElements(int amount)
        {
            var numbers = new List<int>();
            var random = new Random();
            var value = random.Next(1, amount + 1);

            for (int i = 0; i < amount; i++)
            {
                while (numbers.Contains(value))
                {
                    value = random.Next(1, amount + 1);
                }

                numbers.Add(value);
            }

            return numbers;
        }

        public static void Print(int input)
        {
            Console.WriteLine("**** RandomOrder: ");
            var numbers = GetElements(input);

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
        }
    }
}
