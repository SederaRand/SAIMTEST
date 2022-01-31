using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICompanyService
    {
        List<Company> GetCompanies();
        Company GetCompany(int idCompany);
        Task<Company> AddCompany(Company company);
        Task<Company> UpdateCompany(Company company);
        Task DeleteCompany(Company company);
    }
}
