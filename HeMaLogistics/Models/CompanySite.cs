using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HeMaLogistics.Models
{
    public class CompanySite
    {
        [Key]
        public int SiteId { get; set; }
        [Display(Name = "Site Name")]
        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public DayOfWeek DeliveryDate { get; }
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}
