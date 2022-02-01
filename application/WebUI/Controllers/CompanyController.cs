using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using SAIM_FO.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            List<Company> listCompany = _companyService.GetCompanies();
            ViewBag.ListCompany = listCompany;

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
            company.CompanyName = modelView.CompanyName;
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

        [HttpPut]
        [Route("edit/{id}")]
        public IActionResult Update(int idCompany,[FromBody] Company model)
        {           
            Company company = _companyService.GetCompany(idCompany);

            if (company == null ) return RedirectToAction("Index", "Company");

            if (idCompany != company.IdCompany) return RedirectToAction("Index", "Company");

            try
            {
                company.Details = model.Details;
                company.CompanyName = model.CompanyName;
                company.Address = model.Address;

                _companyService.UpdateCompany(company);
            }
            catch (Exception)
            {

                throw;
            }
            
            return View(company);
        }        

        public IActionResult Delete(int idCompany)
        {
            Company company = _companyService.GetCompany(idCompany);

            if (company == null)
            {
                return RedirectToAction("Index", "Company");
            }
            else
            {
                try
                {
                    _companyService.DeleteCompany(company);

                    return RedirectToAction("Index", "Company");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }            
        }

        /*
         * Export List of Companies into Txt
         */
        public void ExportTxt()
        {
            // Where we take the file.txt
            string path = "C:\\Users\\Ibonia\\Documents\\WORK FILE\\PROJECTS\\SAIM TEST\\application\\WebUI\\wwwroot\\txt";

            // Take list of companies
            List<Company> listCompany = _companyService.GetCompanies();

            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (var item in listCompany)
                {
                    tw.WriteLine(string.Format("IdCompany: {0} - Name: {1} - Details: {2} - Address: {3} \n", item.IdCompany, item.CompanyName, item.Details, item.Address));
                }
            }
        }
    }
}
