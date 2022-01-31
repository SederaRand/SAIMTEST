using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(int idUser);
        Task<User> AddImage(User user);
        Task<User> UpdateImage(User user);
        Task DeleteImage(User user);
        bool Login(string username, string password);
    }
}
