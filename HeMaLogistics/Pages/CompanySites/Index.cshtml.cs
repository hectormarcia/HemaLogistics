using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeMaLogistics.Data;
using HeMaLogistics.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HeMaLogistics.Pages.CompanySites
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

            public IndexModel(ApplicationDbContext db)
        {
            _db = db; 
        }

        [BindProperty]
        public SiteAndCompanyViewModel SiteAndCompanyVM { get; set; }

        public async Task<IActionResult> OnGet( int? companyId = null)
        {
            if(companyId==null)
            {
                return NotFound();
            }


            SiteAndCompanyVM = new SiteAndCompanyViewModel()
            {
                CompanySites = await _db.CompanySite.Where(s => s.CompanyId == companyId).ToListAsync(),
                CompanyObj = await _db.Company.FirstOrDefaultAsync(c => c.CompanyId == companyId)
            };

            return Page();
        }
    }
}
