using System;

namespace Practice__
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (ContainsEvenDigit(i) == true &&
                    SumOfDigits(i) == true && IsPalindrome(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int i)
        {
            var number = i.ToString();
            var check = true;
            for (int ii = 0; ii < number.Length; ii++)
            {
                if (number[ii] != number[number.Length - 1 - ii])
                    check = false;
            }
            return check;
        }

        private static bool SumOfDigits(int i)
        {
            long sum = 0;
            while (i!=0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
                return true;
            else
                return false;
        }

        private static bool ContainsEvenDigit(int i)
        {
            var check = false;
            while (i != 0)
            {
                var digit = i % 10;
                if (digit%2==0)
                {
                    check = true;
                    break;
                }
                i /= 10;
            }
            return check;
        }
    }
}
