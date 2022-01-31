using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces.CommonInterfaces
{
    public interface IUserQuery : IRepositoryBase<User>
    {
        List<User> GetUsers();
        User GetUser(int idUser);
        bool Login(string username, string password);
    }
}
