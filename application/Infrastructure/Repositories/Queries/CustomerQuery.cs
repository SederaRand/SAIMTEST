using Domain.Context;
using Domain.Models;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories.Queries
{
    public class CustomerQuery : RepositoryBase<Customer>, ICustomerQuery
    {
        public CustomerQuery(MyDbContext context) : base(context) { }

        public List<Customer> GetCustomers()
        {
            return FindAll().ToList();
        }

        public Customer GetCustomer(int idCustomer)
        {
            return FindAll()
                .FirstOrDefault(o => o.IdCustomer == idCustomer);
        }
    }
}
