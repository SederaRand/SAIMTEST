using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        Contact GetContact(int idContact);
        Task<Contact> AddContact(Contact contact);
        Task<Contact> UpdateContact(Contact contact);
        Task DeleteContact(Contact contact);
    }
}
