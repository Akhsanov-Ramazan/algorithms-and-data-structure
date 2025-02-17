using System;
using System.Security.AccessControl;
namespace PZ
{
    class Programm
    {
        static void Main(string[] args)
        {
            int res = SumOfDigitOfNumbers(1, 100);
            Console.WriteLine(res);
        }
        static int SumOfDigitOfNumbers(int left, int right)
        {
            int sum = 0;
            for (int number = left; number <= right; number++)
            {
                int tmp = number;
                while (tmp > 0)
                {
                    if (tmp % 2 == 0)
                        sum += tmp % 10;
                    tmp /= 10;
                }
            }
            return sum;
        }
    }
}