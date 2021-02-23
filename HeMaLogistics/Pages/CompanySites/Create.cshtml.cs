using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeMaLogistics.Data;
using HeMaLogistics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeMaLogistics.Pages.CompanySites
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public CompanySite CompanySite { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet(int? companyId=null)
        {
            CompanySite = new CompanySite();
            if (companyId == null)
            {
                return NotFound();
            }

            CompanySite.CompanyId = (int)companyId;
            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.CompanySite.Add(CompanySite);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index", new { companyId = CompanySite.CompanyId });
        }
    }
}
