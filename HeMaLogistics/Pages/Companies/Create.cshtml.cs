using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeMaLogistics.Data;
using HeMaLogistics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HeMaLogistics.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Company Company { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Company.Add(Company);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
