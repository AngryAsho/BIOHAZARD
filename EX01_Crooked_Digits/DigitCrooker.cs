using System;

namespace EX01_Crooked_Digits
{
    class DigitCrooker
    {
        static void Main()
        {
            string N = Console.ReadLine();
            double sum = 0;
            double negativeCheck = Double.Parse(N);

            if (negativeCheck < 0)
            {
                negativeCheck *= -1;
                N = negativeCheck.ToString();
            }
            else
            {
                N = negativeCheck.ToString();
            }

            Logic:
            foreach (double i in N)
            {
                sum += (i - 48);
            }

            if (sum > 9)
            {
                N = sum.ToString();
                sum = 0;
                goto Logic;
            }
            else
            {
                N = sum.ToString();
                Console.WriteLine(N);
            }
        }
    }
}