using System;

namespace Zbw.SoftwareTesting.MathLibraryLight.ConsoleTest
{
    /// <summary>
    /// Executes tests based on the inputs and writes the result onto the console
    /// </summary>
    public class Assert
    {

        public const string SuccessMessage = "{0}: Success, {1} ";
        public const string FailedMessage = "{0}: Failed, {1} ";

        private readonly string _title;
        private readonly ConsoleColor _successColor;
        private readonly ConsoleColor _failedColor;

        public Assert(string title, ConsoleColor successColor = ConsoleColor.Green, ConsoleColor failedColor = ConsoleColor.Red)
        {
            _title = title;
            _successColor = successColor;
            _failedColor = failedColor;
            WriteTitle();
        }
        /// <summary>
        /// Write the Title of the Test-series
        /// </summary>
        private void WriteTitle()
        {
            Console.WriteLine(new string('*', (Console.BufferWidth) - 1));
            Console.WriteLine("* " + _title);
            Console.WriteLine(new string('*', (Console.BufferWidth) - 1));
            Console.WriteLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="testName"></param>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        /// <returns></returns>
        public bool AreEqual<T>(string testName, T expected, T actual)
        {
            if (expected.Equals(actual))
            {
                Console.ForegroundColor = _successColor;
                var message = $"Received Expected result: {expected}";
                Console.WriteLine(string.Format(SuccessMessage, testName, message));
                return true;
            }
            else
            {
                Console.ForegroundColor = _failedColor;
                var message = $"Received result: {actual}, Expected: {expected}";
                Console.WriteLine(string.Format(FailedMessage, testName, message));
                return false;
            }
        }
        /// <summary>
        /// Check if the given Method throws the defined Exception and write the result into the console
        /// </summary>
        /// <typeparam name="T">Type of the Exception</typeparam>
        /// <param name="testName">the Name of the Test-Task</param>
        /// <param name="action">the method wrapper</param>
        /// <returns></returns>
        public bool ThrowsException<T>(string testName, Action action)
        {
            var result = false;
            Exception ex = null;

            try
            {
                //try to execute the method
                action();
            }
            catch (Exception e)
            {
                //catch every exception and check the type
                ex = e;
                if (e.GetType() == typeof(T))
                    result = true;
            }
            //handle the result
            if (result)
            {
                Console.ForegroundColor = _successColor;
                var message = $"Received Expected exception: {typeof(T)}";
                Console.WriteLine(string.Format(SuccessMessage, testName, message));
            }
            else
            {
                Console.ForegroundColor = _failedColor;
                var message = ex == null ? "No exception received" : $"Received exception: {ex.GetType()}, Expected: {typeof(T)}";
                Console.WriteLine(string.Format(FailedMessage, testName, message));
            }
            //change back the font color to white
            Console.ForegroundColor = ConsoleColor.White;
            return result;
        }
    }
}
