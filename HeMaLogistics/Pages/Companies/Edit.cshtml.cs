using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HeMaLogistics.Data;
using HeMaLogistics.Models;

namespace HeMaLogistics.Pages.Companies
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _db.Company.FirstOrDefaultAsync(m => m.CompanyId == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var companyFromDb = await _db.Company.FirstOrDefaultAsync(s => s.CompanyId == Company.CompanyId);
            companyFromDb.Name = Company.Name;
            companyFromDb.StreetAddress = Company.StreetAddress;
            companyFromDb.City = Company.City;
            companyFromDb.State = Company.State;
            companyFromDb.PostalCode = Company.PostalCode;
            companyFromDb.Contact = Company.Contact;
            companyFromDb.Phone = Company.Phone;

            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
        
    }
}
