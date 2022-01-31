using Application.Interfaces;
using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyQuery _repositoryCompany;

        public CompanyService(ICompanyQuery repositoryService)
        {
            this._repositoryCompany = repositoryService;
        }

        public async Task<Company> AddCompany(Company company)
        {
            try
            {
                return await this._repositoryCompany.AddAsync(company);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task DeleteCompany(Company company)
        {
            try
            {
                await this._repositoryCompany.Delete(company);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public List<Company> GetCompanies()
        {
            try
            {
                return this._repositoryCompany.GetCompanies();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public Company GetCompany(int idCompany)
        {
            try
            {
                return this._repositoryCompany.GetCompany(idCompany);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            try
            {
                return await this._repositoryCompany.UpdateAsync(company);
            }
            catch (Exception ex) 
            { 
                throw new Exception($"Couldn't retrieve entities: {ex.Message}"); 
            }
        }
    }
}
