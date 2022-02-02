using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SAIM_FO.Models
{
    public class ContactModel
    {
        public int IdContact { get; set; }
        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage = "Le nom de la société")]
        public string Company { get; set; }
    }
}
