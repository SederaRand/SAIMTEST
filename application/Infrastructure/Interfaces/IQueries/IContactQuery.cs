using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces.IQueries
{
    public interface IContactQuery : IRepositoryBase<Contact>
    {
        List<Contact> GetContacts();
        Contact GetContact(int idContact);
    }
}
