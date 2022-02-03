using Application.Interfaces;
using AspNetCoreHero.ToastNotification.Abstractions;
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

        private readonly INotyfService _notyf;

        
        public static Dictionary<int, string> listBoxCompanies = new Dictionary<int, string>();

        public ContactController(IContactService contactService, ICompanyService companyService, INotyfService notyf)
        {
            this._contactService = contactService;
            this._companyService = companyService;
            this._notyf = notyf;
        }

        public IActionResult Index()
        {
            List<Contact> listContact = _contactService.GetContacts();

            List<ContactModel> listContactModel = new List<ContactModel>();

            foreach (var contact in listContact)
            {
                var companyName = _companyService.GetCompany(contact.CompanyId);

                ContactModel contactModel = new ContactModel();
                contactModel.IdContact = contact.IdContact;
                contactModel.FirstName = contact.FirstName;
                contactModel.LastName = contact.LastName;
                contactModel.Phone = contact.Phone;
                contactModel.Status = contact.Status;
                contactModel.Company = companyName.CompanyName;

                listContactModel.Add(contactModel);
               
            }

            ViewBag.ListContact = listContactModel;            

            return View();
        }

        /*
         * Init the list of companies in the View Create
         */
        private IEnumerable<string> initList()
        {
            List<Company> listCompanies = _companyService.GetCompanies();

            if (listBoxCompanies.Count == 0)
            {
                foreach (var company in listCompanies) listBoxCompanies.Add(company.IdCompany, company.CompanyName);
                var finalList = listBoxCompanies.Select(x => x.Value);

                return finalList;
            }
            else
            {
                Console.WriteLine(listBoxCompanies);

                var finalList = listBoxCompanies.Select(x => x.Value);
                return finalList;
            }
        }

        public IActionResult Create()
        {
            var listCompanies = initList();

            ViewBag.ListCompanies = listCompanies;
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactModel modelView)
        {
            if (ModelState.IsValid)
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

                    _notyf.Success("Contact ajouté avec succès");
                    return RedirectToAction("Index", "Contact");
                }
                catch (Exception)
                {
                    _notyf.Error("Enregistrement échoué");
                    return RedirectToAction("Create", "Contact");
                }
            }

            var listCompanies = initList();

            ViewBag.ListCompanies = listCompanies;

            return View();
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

                    _notyf.Information("Client supprimé");
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
