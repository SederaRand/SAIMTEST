using Domain.Context;
using Domain.Models;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories.Queries
{
    public class ContactQuery : RepositoryBase<Contact>, IContactQuery
    {
        public ContactQuery(MyDbContext context) : base(context) { }

        public List<Contact> GetContacts()
        {
            return FindAll().ToList();
        }

        public Contact GetContact(int idContact)
        {
            return FindAll()
                .FirstOrDefault(o => o.IdContact == idContact);
        }
    }
}
