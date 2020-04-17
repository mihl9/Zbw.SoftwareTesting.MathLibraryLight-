using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zbw.SoftwareTesting.MathLibraryLight.Test
{
    [TestClass]
    public class BasicOperationsShould
    {
        private readonly BasicOperations _basicOperations;

        public BasicOperationsShould()
        {
            _basicOperations = new BasicOperations();
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(100, 50, 150)]
        [DataRow(int.MaxValue, int.MinValue, -1)]
        public void AdditionEquals(int val1, int val2, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Addition(val1, val2));
        }

        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(int.MaxValue, int.MinValue, -1)]
        public void SubtractionEquals(int val1, int val2, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Subtraction(val1, val2));
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(10, 2, 5)]
        public void DivisionTrue(int val1, int val2, double expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Division(val1, val2));
        }

        [TestMethod]
        public void DivisionZeroDivision()
        {
            Assert.ThrowsException<ZeroDivisorNotAllowed>(() => _basicOperations.Division(100, 0));
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(10, 2, 20)]
        public void MultiplicationTrue(int val1, int val2, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Multiplication(val1, val2));
        }
    }
}