using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCompany { get; set; }
        public string Details { get; set; }
        public string Contact { get; set; }
        public string ContactStatus { get; set; }
        //public int IdCustomers { get; set; }
    }
}
