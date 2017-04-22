using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Social_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
            var counter = 0;
            while (input != "drop the media")
            {
                var splitWords = input.Split(' ').ToList();
                var command = splitWords[0]; var post = splitWords[1];

                if (command == "post")
                {
                    data[post] = new Dictionary<string, Dictionary<string, string>>();
                    data[post]["Likes"] = new Dictionary<string, string>();
                    data[post]["Dislikes"] = new Dictionary<string, string>();
                    data[post]["Comments"] = new Dictionary<string, string>();
                    data[post]["Comments"].Add("None", "None");
                }
                else if (command == "like")
                {
                    counter++;
                    data[post]["Likes"].Add(counter.ToString(), null);
                }
                else if (command == "dislike")
                {
                    counter++;
                    data[post]["Dislikes"].Add(counter.ToString(), null);
                }
                else if (command == "comment")
                {
                    var name = splitWords[2];
                    splitWords.RemoveAt(0); splitWords.RemoveAt(0);
                    splitWords.RemoveAt(0);
                    var comment = string.Join(" ", splitWords);
                    data[post]["Comments"].Remove("None");
                    data[post]["Comments"].Add(name, comment);
                }
                input = Console.ReadLine();
            }

            foreach (var post in data)
            {
                Console.Write($"Post: {post.Key}");
                foreach (var item in post.Value)
                {
                    if (item.Key == "Likes")
                    {
                        Console.Write($" | Likes: {item.Value.Count} | ");
                    }
                    else if (item.Key == "Dislikes")
                    {
                        Console.WriteLine($"Dislikes: {item.Value.Count}");
                    }
                    else if (item.Key == "Comments")
                    {
                        Console.WriteLine($"Comments:");
                        if (item.Value.ContainsValue("None"))
                        {
                            Console.WriteLine("None");
                        }
                        else
                        {
                            foreach (var user in item.Value)
                            {
                                Console.WriteLine($"*  {user.Key}: {user.Value}");
                            }
                        }
                    }
                }
            }
        }
    }
}
