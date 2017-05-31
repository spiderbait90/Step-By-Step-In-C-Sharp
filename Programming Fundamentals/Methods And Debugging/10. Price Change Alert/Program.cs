using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double treshHold = double.Parse(Console.ReadLine());

        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double diff = Proc(last, currentPrice);
            bool isSignificantDifference = DiffCheck(diff, treshHold);

            string message = Get(currentPrice, last, diff, isSignificantDifference);
            Console.WriteLine(message);

            last = currentPrice;
        }
    }

    private static string Get(double currentPrice, double last, double diff, bool etherTrueOrFalse)

    {
        string print = "";
        if (diff == 0)
        {
            print = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            print = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, currentPrice, diff * 100);
        }
        else if (etherTrueOrFalse && (diff > 0))
        {
            print = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, currentPrice, diff * 100);
        }
        else if (etherTrueOrFalse && (diff < 0))
            print = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, currentPrice, diff * 100);
        return print;
    }
    private static bool DiffCheck(double treshHold, double isDiff)
    {
        if (Math.Abs(treshHold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double last, double currentPrice)
    {
        double result = (currentPrice - last) / last;
        return result;
    }
}


