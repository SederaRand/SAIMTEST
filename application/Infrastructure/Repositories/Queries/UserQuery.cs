using Domain.Context;
using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories.Queries
{
    public class UserQuery : RepositoryBase<User>, IUserQuery
    {
        public UserQuery(MyDbContext context) : base(context) { }

        public List<User> GetUsers()
        {
            return FindAll().ToList();
        }

        public User GetUser(int idUser)
        {
            return FindAll()
                .FirstOrDefault(o => o.IdUser == idUser);
        }

        public bool Login(string username, string password)
        {
            return FindAll().Any(x => x.Username == username && x.Password == password);
        }
    }
}
