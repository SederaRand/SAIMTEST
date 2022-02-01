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
    public class ContactController : Controller
    {
        private IContactService _contactService;
        private ICompanyService _companyService;

        public static Dictionary<int, string> listBoxCompanies = new Dictionary<int, string>();

        public ContactController(IContactService contactService, ICompanyService companyService)
        {
            this._contactService = contactService;
            this._companyService = companyService;
        }

        public IActionResult Index()
        {
            List<Contact> listContact = _contactService.GetContacts();
            ViewBag.ListContact = listContact;            

            return View();
        }

        public IActionResult Create()
        {
            // Take list of companies
            List<Company> listCompanies = _companyService.GetCompanies();           

            foreach (var company in listCompanies) listBoxCompanies.Add(company.IdCompany, company.CompanyName);

            ViewBag.ListCompanies = listBoxCompanies.Select(x => x.Value);

            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel modelView)
        {
            Contact contact = new Contact();

            contact.FirstName = modelView.FirstName;
            contact.LastName = modelView.LastName;
            contact.Phone = modelView.Phone;

            if (modelView.Status.ToString() == "Favorites") contact.Status = true;
            else contact.Status = false;

            string company = modelView.Company;
            var id = listBoxCompanies.FirstOrDefault(x => x.Value == company).Key;

            contact.CompanyId = id;

            try
            {
                _contactService.AddContact(contact);

                return RedirectToAction("Index", "Contact");
            }
            catch (Exception)
            {
                return RedirectToAction("Create", "Contact");
            }
        }

        public IActionResult Delete(int idContact)
        {
            Contact contact = _contactService.GetContact(idContact);

            if (contact == null)
            {
                return RedirectToAction("Index", "Contact");
            }
            else
            {
                try
                {
                    _contactService.DeleteContact(contact);

                    return RedirectToAction("Index", "Contact");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
