using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Practice
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new SortedDictionary<string, List<Sale>>();
            var result = ReanAndStoreSales(n, sales);
            PrintResult(result);
        }

        private static void PrintResult(SortedDictionary<string, List<Sale>> result)
        {
            foreach (var item in result)
            {
                decimal sum = 0;
                foreach (var sale in item.Value)
                {
                    sum += (sale.Price * sale.Quantity);
                }
                Console.WriteLine($"{item.Key} -> {sum:f2}");
            }
        }

        public static SortedDictionary<string, List<Sale>> ReanAndStoreSales(int n, SortedDictionary<string, List<Sale>> sales)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var sale = new Sale();
                sale.Town = input[0];
                sale.Product = input[1];
                sale.Price = decimal.Parse(input[2]);
                sale.Quantity = decimal.Parse(input[3]);

                if (!sales.ContainsKey(sale.Town))
                    sales[sale.Town] = new List<Sale>();

                sales[sale.Town].Add(sale);
            }
            return sales;
        }
    }
}
