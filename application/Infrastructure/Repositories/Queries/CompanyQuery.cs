using Domain.Context;
using Domain.Models;
using Infrastructure.Interfaces.CommonInterfaces;
using Infrastructure.Interfaces.IQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories.Queries
{
    public class CompanyQuery : RepositoryBase<Company>, ICompanyQuery
    {
        public CompanyQuery(MyDbContext context) : base(context) { }

        public List<Company> GetCompanies()
        {
            return FindAll().ToList();
        }

        public Company GetCompany(int idCompany)
        {
            return FindAll()
                .FirstOrDefault(o => o.IdCompany == idCompany);
        }
    }
}
