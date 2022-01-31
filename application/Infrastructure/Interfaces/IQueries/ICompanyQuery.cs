using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Interfaces.IQueries
{
    public interface ICompanyQuery : IRepositoryBase<Company>
    {
        List<Company> GetCompanies();
        Company GetCompany(int idCompany);
    }
}
