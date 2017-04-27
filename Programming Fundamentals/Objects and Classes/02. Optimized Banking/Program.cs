using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var accounts = new List<BankAccount>();
            
            while (input!="end")
            {
                var split = input.Split(new[] { ' ', '|' }
                , StringSplitOptions.RemoveEmptyEntries);
                
                var bankAcc = new BankAccount();
                bankAcc.Bank = split[0];
                bankAcc.Name = split[1];
                bankAcc.Balance = decimal.Parse(split[2]);
                accounts.Add(bankAcc);
                input = Console.ReadLine();
            }
            
            foreach (var item in accounts.OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{item.Name} -> {item.Balance} ({item.Bank})");
            }

        }

    }
    public class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
}
