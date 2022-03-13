using System.Collections.Generic;

namespace Forum.Models
{
    public class Data : IData
    {
        public List<User> Users { get; set; }
        public List<Post> Posts { get; set; }

        public Data()
        {
            this.Posts = new List<Post>()
            {
                new Post("Some Content"),
                new Post("More Content"),
                new Post("Another Content"),
            };

            this.Users = new List<User>()
            {
                new User(1, "ASd", "Gosho", "Goshev"),
                new User(2, "ani123", "Ani", "Dimova"),
                new User(3, "iva22", "Iva", "Stoyanova"),
                new User(4, "gotinSimo12", "Simo", "Georgiev")
            };
        }
    }
}

