using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double treshHold = double.Parse(Console.ReadLine());
        var last = 0.0;
        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double div = Proc(last, price);
            bool isSignificantDifference = imaliDif(div, treshHold);

            string message = Get(price, last, div, isSignificantDifference);
            Console.WriteLine(message);

            last = price;
        }
    }

    private static string Get(double price, double last, double razlika, bool etherTrueOrFalse)

    {
        string to = "";
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", price);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, razlika);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, razlika);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, razlika);
        return to;
    }
    private static bool imaliDif(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
