using Application.Interfaces;
using Domain.Models;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactQuery _repositoryContact;

        public ContactService(IContactQuery repositoryService)
        {
            this._repositoryContact = repositoryService;
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            try
            {
                return await this._repositoryContact.AddAsync(contact);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task DeleteContact(Contact contact)
        {
            try
            {
                await this._repositoryContact.Delete(contact);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public Contact GetContact(int idContact)
        {
            try
            {
                return this._repositoryContact.GetContact(idContact);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public List<Contact> GetContacts()
        {
            try
            {
                return this._repositoryContact.GetContacts();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
            try
            {
                return await this._repositoryContact.UpdateAsync(contact);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }
    }
}
