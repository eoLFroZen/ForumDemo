using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Services
{
    public class PostService
    {
        public List<Post> GetAll()
        {
            return Data.Posts;
        }

        public Post Create(string content)
        {
            Post post = new Post(content);

            Data.Posts.Add(post);

            return post;
        }

      
    }
}
