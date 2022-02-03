using Application.Interfaces;
using AspNetCoreHero.ToastNotification.Abstractions;
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
        private readonly INotyfService _notyf;

        public CompanyController(ICompanyService companyService, INotyfService notyf)
        {
            this._companyService = companyService;
            this._notyf = notyf;
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
            if (ModelState.IsValid)
            {
                Company company = new Company();

                company.Details = modelView.Details;
                company.CompanyName = modelView.CompanyName;
                company.Address = modelView.Address;

                try
                {
                    _companyService.AddCompany(company);

                    _notyf.Success("Client ajouté avec succès");
                    return RedirectToAction("Index", "Company");
                    
                }
                catch (Exception)
                {
                    _notyf.Error("Enregistrement échoué");
                    return RedirectToAction("Create", "Company");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int idCompany)
        {         
            try
            {
                Company company = _companyService.GetCompany(idCompany);
                return View(company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]       
        public IActionResult Update(Company model)
        {
            Company company = _companyService.GetCompany(model.IdCompany);

            if (company.IdCompany != null && company.IdCompany == model.IdCompany)
            {
                company.Details = model.Details;
                company.CompanyName = model.CompanyName;
                company.Address = model.Address;

                try
                {
                    _companyService.UpdateCompany(company);

                    _notyf.Success("Client modifié avec succès");
                    return RedirectToAction("Index", "Company");
                }
                catch (Exception)
                {
                    _notyf.Error("Modification échoué");
                    return RedirectToAction("Create", "Company");
                }
            }
            else
            {
                return RedirectToAction("Create", "Company");
            }
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

                    _notyf.Information("Client supprimé");
                    return RedirectToAction("Index", "Company");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }            
        }

        /*
         * Function for Export List of Companies into File Txt
         */
        public IActionResult ExportTxt()
        {           
            try
            {
                List<Company> listCompany = _companyService.GetCompanies();

                string pathSystem = System.IO.Directory.GetCurrentDirectory();

                string nameFile = "companies.txt";             

                using (TextWriter tw = new StreamWriter(pathSystem + "\\Others\\ExportFile\\" + nameFile))
                {
                    foreach (var item in listCompany)
                    {
                        tw.WriteLine(string.Format("{0}; {1}; {2}", item.CompanyName, item.Details, item.Address));
                    }
                }

                _notyf.Success("Export réussi bravo !");
                return RedirectToAction("Index", "Company");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
         * Function for Import File txt list of companies
         */
        [HttpPost]
        public ActionResult ImportTxt(IFormFile file)
        {
            Console.WriteLine(file);
            try
            {
                if (file.Length > 0)
                {
                    string pathSystem = System.IO.Directory.GetCurrentDirectory();

                    string _path = pathSystem + "\\Others\\ImportFile\\" + file.FileName;

                    // Create a new list
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
                    // Post the list
                    foreach (var company in listCompany)
                    {
                        _companyService.AddCompany(company);
                    }
                }

                _notyf.Success("Importation réussi bravo !");
                return RedirectToAction("Index", "Company");
            }
            catch(Exception ex)
            {
                throw ex;

                _notyf.Error("L'importation a echoué !");
                return RedirectToAction("Index", "Company");
            }
        }
    }
}
