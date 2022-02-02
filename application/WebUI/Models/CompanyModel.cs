using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAIM_FO.Models
{
    public class CompanyModel
    {
        public string Details { get; set; }
        [Required(ErrorMessage = "Le nom de la société est obligatoire")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "L'adresse de la société est obligatoire")]
        public string Address { get; set; }
    }
}
