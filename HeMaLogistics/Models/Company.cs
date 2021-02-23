using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeMaLogistics.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Display(Name = "Company Name")]
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
    }
}
