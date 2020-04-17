using System;
using Zbw.SoftwareTesting.MathLibraryLight;

namespace Zbw.SoftwareTesting.MathLibrary.ConsoleTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var tester = new Assert("Basic Operations");
            var basicOperations = new BasicOperations();

            tester.AreEqual("Addition", 10, basicOperations.Addition(5, 5));

            tester.AreEqual("Subtraction", 0, basicOperations.Subtraction(5, 5));

            tester.AreEqual("Division", 1, basicOperations.Division(5, 5));

            tester.ThrowsException<ZeroDivisorNotAllowed>("Zero Division", () => basicOperations.Division(10, 0));

            tester.AreEqual("Multiplication", 25, basicOperations.Multiplication(5, 5));

            Console.ReadKey();
        }
    }
}
