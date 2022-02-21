using ConsoleAlgorithms.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TripleCyberSkillsTest.Tests
{
    [TestClass]
    public class AlgorithmsUT
    {
        [TestMethod]
        public void BreakdownBillsTest()
        {
            var result = BreakdownBills.GetDetails(17984);
            var seed = new List<string>() {"8 x 2000 = 16000"
                                        ,"1 x 1000 = 1000"
                                        ,"1 x 500 = 500"
                                        ,"2 x 200 = 400"
                                        ,"1 x 50 = 50"
                                        ,"1 x 25 = 25"
                                        ,"1 x 5 = 5"
                                        ,"4 x 1 = 4" };

            CollectionAssert.AreEqual(seed, result, GetMessageFromList(seed, result));
        }

        [TestMethod]
        public void FibonacciTest()
        {
            var result = Fibonacci.GetSequence(11);
            var seed = new List<long>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            CollectionAssert.AreEqual(seed, result, GetMessageFromList(seed, result));
        }

        // This test doesn't evaluate if a number is random, just the elements inside 
        [TestMethod]
        public void RandomOrderTest()
        {
            var result = RandomOrder.GetElements(5).OrderBy(x => x).ToList();
            var seed = new List<int>() { 1, 2, 3, 4, 5 };

            CollectionAssert.AreEqual(seed, result, GetMessageFromList(seed, result));
        }

        public string GetMessageFromList(dynamic expected, dynamic found)
        {
            return $"Expected: [{String.Join(", ", expected)}], found: [{String.Join(", ", found)}] ";
        }
    }
}
