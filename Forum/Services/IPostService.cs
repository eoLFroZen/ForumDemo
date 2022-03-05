using Forum.Models;
using System.Collections.Generic;

namespace Forum.Services
{
    public interface IPostService
    {
        Post Create(string content);
        Post Delete(int id);
        Post Edit(int id, string content);
        List<Post> GetAll();
        Post GetById(int id);
    }
}