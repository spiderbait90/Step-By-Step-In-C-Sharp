using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    public class Custumer
    {
        public string Name { get; set; }
        public Dictionary<string, long> ShopList { get; set; }
        public decimal Bill { get; set; }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var shop = new Dictionary<string, decimal>();
            var custumurs = new Dictionary<string, Custumer>();

            for (long i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var product = input[0];
                var price = decimal.Parse(input[1]);
                shop[product] = price;
            }
            var input2 = Console.ReadLine();
            while (input2 != "end of clients")
            {
                var split = input2
                    .Split(new[] { ',', '-' });

                var name = split[0];
                var product = split[1];
                var quantity = long.Parse(split[2]);

                if (shop.ContainsKey(product))
                {
                    var custumer = new Custumer();
                    custumer.Name = name;
                    custumer.ShopList = new Dictionary<string, long>();
                    custumer.ShopList.Add(product, quantity);
                    if (!custumurs.ContainsKey(name))
                        custumurs.Add(name, custumer);
                    else
                    {
                        if (!custumurs[name].ShopList.ContainsKey(product))
                            custumurs[name].ShopList.Add(product, quantity);
                        else
                            custumurs[name].ShopList[product] += quantity;
                    }                    
                }
                input2 = Console.ReadLine();                
            }

            foreach (var client in custumurs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{client.Key}");
                foreach (var item in client.Value.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                    client.Value.Bill += (shop[item.Key] * custumurs[client.Key].ShopList[item.Key]);
                }
                Console.WriteLine($"Bill: {client.Value.Bill:f2}");
            }
            Console.WriteLine($"Total bill:" +
                $" {custumurs.Values.Sum(x => x.Bill):f2}");
        }
    }
}
