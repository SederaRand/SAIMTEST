using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces.IQueries
{
    public interface ICustomerQuery : IRepositoryBase<Customer>
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(int idCustomer);
    }
}
