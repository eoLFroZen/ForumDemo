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

        public Post Edit(int id, string content)
        {
            Post post = GetById(id);
            post.Content = content;

            return post;
        }

        public Post GetById(int id)
        {
            return Data.Posts.FirstOrDefault(p => p.Id == id);
        }
    }
}
