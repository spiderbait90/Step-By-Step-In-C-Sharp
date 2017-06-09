using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    public class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Damage { get; set; }
        public decimal Health { get; set; }
        public decimal Armor { get; set; }
    }
    public class Program
    {
      public static void Main(string[] args)
        {
            var data = new Dictionary<string, SortedDictionary<string, Dragon>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var type = input[0];
                var name = input[1];
                var damage = 0m;
                var health = 0m;
                var armor = 0m;

                if (input[2] == "null")
                    damage = 45;
                else
                    damage = int.Parse(input[2]);

                if (input[3] == "null")
                    health = 250;
                else
                    health = int.Parse(input[3]);

                if (input[4] == "null")
                    armor = 10;
                else
                    armor = int.Parse(input[4]);
                if (!data.ContainsKey(type))
                    data[type] = new SortedDictionary<string, Dragon>();
                if (!data[type].ContainsKey(name))
                    data[type][name] = new Dragon();

                data[type][name].Name = name;
                data[type][name].Health = health;
                data[type][name].Damage = damage;
                data[type][name].Armor = armor;
                data[type][name].Type = type;
            }            

            foreach (var type in data)
            {
               var armor = new List<decimal>();
                var health = new List<decimal>();
                var damage = new List<decimal>();
                foreach (var item in type.Value)
                {
                    armor.Add(item.Value.Armor);
                    health.Add(item.Value.Health);
                    damage.Add(item.Value.Damage);
                }           
                    
                Console.WriteLine($"{type.Key}::" +
                    $"({damage.Average():f2}/{health.Average():f2}/{armor.Average():f2})");
                foreach (var item in type.Value)
                {
                    Console.WriteLine($"-{item.Value.Name} -> " +
                        $"damage: {item.Value.Damage}, " +
                        $"health: {item.Value.Health}, " +
                        $"armor: {item.Value.Armor}");
                }
            }
        }
    }
}
