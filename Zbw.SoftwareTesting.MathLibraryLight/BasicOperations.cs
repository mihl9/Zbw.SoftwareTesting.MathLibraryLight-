namespace Zbw.SoftwareTesting.MathLibraryLight
{
    public class BasicOperations
    {
        public BasicOperations()
        {
        }

        public int Addition(int first, int second)
        {
            return first + second;
        }

        public int Subtraction(int first, int second)
        {
            return first - second;
        }

        public double Division(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new ZeroDivisorNotAllowed();

            
            return (double)dividend / divisor;
        }

        public int Multiplication(int first, int second)
        {
            return first * second;
        }
        
    }
}
