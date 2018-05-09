using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();

        while (true)
        {
            var input = Console.ReadLine().Split(' ');
            if (input[0] == "End")
                break;

            if (input[0] == "Deposit")
                Deposit(input, accounts);

            else if (input[0] == "Create")
                Create(input, accounts);

            else if (input[0] == "Withdraw")
                Withdraw(input, accounts);

            else if (input[0] == "Print")
                Print(input, accounts);

        }
    }

    public static void Print(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine($"Account ID{id}, balance {accounts[id].Balance:f2}");
        }
    }

    public static void Withdraw(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        var balance = decimal.Parse(input[2]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else if (accounts[id].Balance < balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accounts[id].Withdraw(balance);
        }
    }

    public static void Create(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount
            {
                ID = id
            };
            accounts.Add(id, acc);
        }
    }

    public static void Deposit(string[] input, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(input[1]);
        var balance = decimal.Parse(input[2]);

        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(balance);
        }
    }
}

