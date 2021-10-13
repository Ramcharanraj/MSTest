using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfTwoNumbersDemo;

namespace SumOfTwoNumbersMSTestUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        private readonly SumOfTwoNumbersDemo.Program program;

        public UnitTest1()
        {
            program = new SumOfTwoNumbersDemo.Program(); 
        }

        [TestMethod]
        public void TestMethod1()
        {
            int valueOne = 5;
            int valueTwo = 10;
            var result = program.Add(valueOne, valueTwo);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int valueOne = 59;
            int valueTwo = 10;
            var result = program.Add(valueOne, valueTwo);
            Assert.AreEqual(15, result);
        }


    }
}
