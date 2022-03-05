using Forum.Models;
using System.Collections.Generic;

namespace Forum
{
    public interface IData
    {
        List<Post> Posts { get; set; }
    }
}