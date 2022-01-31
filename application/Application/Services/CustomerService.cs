using Application.Interfaces;
using Domain.Models;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerQuery _repositoryCustomer;

        public CustomerService(ICustomerQuery repositoryService)
        {
            this._repositoryCustomer = repositoryService;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            try
            {
                return await this._repositoryCustomer.AddAsync(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task DeleteCustomer(Customer customer)
        {
            try
            {
                await this._repositoryCustomer.Delete(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public Customer GetCustomer(int idCustomer)
        {
            try
            {
                return this._repositoryCustomer.GetCustomer(idCustomer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                return this._repositoryCustomer.GetCustomers();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            try
            {
                return await this._repositoryCustomer.UpdateAsync(customer);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }
    }
}
