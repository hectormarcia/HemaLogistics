using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HeMaLogistics.Models
{
    public class ActivityType
    {
        [Key]
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }        
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public virtual ServiceType ServiceType { get; set; }
    }
}
