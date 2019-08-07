using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Number_Divide_By_Zero_Throws_DivideByZeroException_TestMethod()
        {
            var divide = new CalculatorDivideFunction();
            divide.GetResultByDivide(40, 0);
        }
    }
}
