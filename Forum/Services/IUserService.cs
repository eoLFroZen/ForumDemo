using Forum.Models;
using Forum.Models.DTOs;
using System.Collections.Generic;

namespace Forum.Services
{
    public interface IUserService
    {
        List<UserDTO> GetAll();
        void Create(UserDTO userDto);
        void Edit(int id, UserDTO userDto);
        void Delete(int id);
        UserDTO GetById(int id);
    }
}