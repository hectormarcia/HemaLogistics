using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeMaLogistics.Models
{
    public class ServiceType
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Price { get; set; }
    }
}
