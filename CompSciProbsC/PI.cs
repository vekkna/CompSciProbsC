namespace CompSciProbsC
{
    public class PI
    {
        public static double FindPI(int precision)
        {
            double result = 0d;
            double numerator = 4;
            double denominator = 1;
            int op = 1;

            for (int i = 0; i < precision; i++)
            {
                result += numerator / denominator * op;
                denominator += 2;
                op *= -1;
            }
            return result;
        }
    }
}