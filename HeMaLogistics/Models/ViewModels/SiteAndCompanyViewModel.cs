using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeMaLogistics.Models.ViewModels
{
    public class SiteAndCompanyViewModel
    {
        public Company CompanyObj { get; set; }
        public IEnumerable<CompanySite> CompanySites { get; set; }
    }
}
