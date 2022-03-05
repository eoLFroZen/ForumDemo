using System.Collections.Generic;

namespace Forum.Models
{
    public interface IData
    {
        List<User> Users { get; set; }
    }
}