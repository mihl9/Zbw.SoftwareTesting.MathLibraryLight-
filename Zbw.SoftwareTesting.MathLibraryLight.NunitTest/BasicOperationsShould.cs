using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Zbw.SoftwareTesting.MathLibraryLight.NunitTest
{
    [TestFixture]
    public class BasicOperationsShould
    {

        private BasicOperations _basicOperations;
        
        [SetUp]
        public void SetUp()
        {
            _basicOperations = new BasicOperations();
        }

        [TestCase(1, 1, 2)]
        [TestCase(100, 50, 150)]
        [TestCase(int.MaxValue, int.MinValue, -1)]
        public void AdditionEquals(int val1, int val2, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Addition(val1, val2));
        }

        [TestCase(1, 1, 0)]
        [TestCase(int.MaxValue, int.MinValue, -1)]
        public void SubtractionEquals(int val1, int val2, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Subtraction(val1, val2));
        }

        [TestCase(1, 1, 1)]
        [TestCase(10, 2, 5)]
        public void DivisionEquals(int val1, int val2, double expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Division(val1, val2));
        }

        [Test]
        public void DivisionZeroDivision()
        {
            Assert.Throws<ZeroDivisorNotAllowed>(() => _basicOperations.Division(100, 0));
        }

        [TestCase(1, 1, 1)]
        [TestCase(10, 2, 20)]
        public void MultiplicationEquals(int val1, int val2, int expectedResult)
        {
            Assert.AreEqual(expectedResult, _basicOperations.Multiplication(val1, val2));
        }
    }
}
