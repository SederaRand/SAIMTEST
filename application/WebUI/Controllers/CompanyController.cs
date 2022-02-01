using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using SAIM_FO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAIM_FO.Controllers
{
    public class CompanyController : Controller
    {
        private ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            this._companyService = companyService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CompanyModel modelView)
        {
            Company company = new Company();

            company.Details = modelView.Details;
            company.Address = modelView.Address;

            try
            {
                _companyService.AddCompany(company);

                return RedirectToAction("Index", "Company");
            }
            catch (Exception)
            {

                return RedirectToAction("Create", "Company");
            }
            
        }
    }
}
