using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
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
<<<<<<< HEAD
        public IActionResult ExportTxt()
        {           
            try
            {
                List<Company> listCompany = _companyService.GetCompanies();

                using (TextWriter tw = new StreamWriter("C:\\Users\\Ibonia\\Desktop\\Params\\companies.txt"))
                {
                    foreach (var item in listCompany)
                    {
                        tw.WriteLine(string.Format("{0}; {1}; {2}", item.CompanyName, item.Details, item.Address));
                    }
                }

                return RedirectToAction("Index", "Company");
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
         * Import Txt list of companies
         */
        [HttpPost]
        public ActionResult ImportTxt(IFormFile file)
        {
            Console.WriteLine(file);
            try
            {
                if (file.Length > 0)
                {
                    string filePath = @"C:\Users\Public\Documents\";

                    string fileName = Path.GetDirectoryName(file.FileName);
                    string _path = filePath + fileName;

                    //Create a new list
                    List<Company> listCompany = new List<Company>(); 
                    
                    // Convert the content of list into string
                    string contents = System.IO.File.ReadAllText(_path);

                    //Execute a loop over the rows.
                    foreach (string row in contents.Split('\n'))
                    {
                        if (!string.IsNullOrEmpty(row))
                        {
                            listCompany.Add(new Company
                            {                               
                                CompanyName = row.Split(';')[0],
                                Details = row.Split(';')[1],
                                Address = row.Split(';')[2]
                            });
                        }
                    }

                    Console.WriteLine(listCompany.Count);
                    // Post the list
                    foreach (var company in listCompany)
                    {
                        _companyService.AddCompany(company);
                    }
                }

                ViewBag.Message = "Import Successfully!!";
                return RedirectToAction("Index", "Company");
            }
            catch(Exception ex)
            {
                throw ex;

                ViewBag.Message = "Import failed!!";
                return RedirectToAction("Index", "Company");
=======
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
>>>>>>> 66b4072980ce8ae5c80ed7a8f618eb996ce1946e
            }
        }
    }
}
