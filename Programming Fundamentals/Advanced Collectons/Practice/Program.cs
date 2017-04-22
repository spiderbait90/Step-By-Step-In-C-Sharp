using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, Dictionary<string,List<string>>>>();

            while (input != "drop the media")
            {
                var splitWords = input.Split(' ');
                var command = splitWords[0]; var post = splitWords[1];

                if (command == "post")
                {
                    if (!data.ContainsKey(post))
                    {
                        data[post] = new Dictionary<string, Dictionary<string, List<string>>>();
                    }
                }
                else if (command == "like")
                {
                    if (!data[post].ContainsKey("Likes"))
                    {
                        data[post]["Likes"] = new Dictionary<string, List<string>>();
                        data[post]["Likes"]["like"] = new List<string>();
                        data[post]["Likes"]["like"].Add("likeCount");
                    }
                    else
                    {
                        data[post]["Likes"]["like"].Add("likeCount");
                    }
                    
                }
                else if (command == "dislike")
                {
                    if (!data[post].ContainsKey("Dislikes"))
                    {
                        data[post]["Dislikes"] = new Dictionary<string, List<string>>();
                        data[post]["Dislikes"]["dislike"] = new List<string>();
                        data[post]["Dislikes"]["dislike"].Add("dislikeCount");
                    }
                    else
                    {
                        data[post]["Dislikes"]["dislike"].Add("dislikeCount");
                    }
                }
                else if (command == "comment")
                {
                   

                }
                input = Console.ReadLine();
            }
            

        }
    }
}

