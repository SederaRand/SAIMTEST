using Application.Interfaces;
using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserQuery _repositoryUser;

        public UserService(IUserQuery repositoryService)
        {
            this._repositoryUser = repositoryService;
        }

        public async Task<User> AddImage(User user)
        {
            try
            {
                return await this._repositoryUser.AddAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task DeleteImage(User user)
        {
            try
            {
                await this._repositoryUser.Delete(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public User GetUser(int idUser)
        {
            try
            {
                return this._repositoryUser.GetUser(idUser);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public List<User> GetUsers()
        {
            try
            {
                return this._repositoryUser.GetUsers();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> UpdateImage(User user)
        {
            try
            {
                return await this._repositoryUser.UpdateAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }
    }
}
