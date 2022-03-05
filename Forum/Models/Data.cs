using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum
{
    public static class Data
    {
        public static List<Post> Posts { get; set; }

        static Data()
        {
            Posts = new List<Post>()
            {
                new Post("Some Content"),
                new Post("More Content"),
                new Post("Another Content"),
            };
        }
    }
}
