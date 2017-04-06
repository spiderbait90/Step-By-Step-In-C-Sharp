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
                if (ContainsEvenDigit(i) && SumOfDigits(i) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool ContainsEvenDigit(int i)
        {
            bool check = false;

            while (i > 0)
            {
                var digit = i % 10;
                if (digit % 2 == 0)
                {
                    check = true; ; break;
                }
                i /= 10;
            }
            return check;
        }

        private static bool SumOfDigits(int i)
        {
            bool chek = false;
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
                chek = true;
            return chek;
        }

        private static bool IsPalindrome(int i)
        {
            bool check = false; var iCopy = i;
            string reverse = "";
            while (iCopy > 0)
            {
                var digit = iCopy % 10;
                reverse += digit;
                iCopy /= 10;
            }
            
            if (i.ToString() == reverse)
                check = true;
            return check;


        }
    }
}
