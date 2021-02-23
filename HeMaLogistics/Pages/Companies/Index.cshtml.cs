using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeMaLogistics.Data;
using HeMaLogistics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HeMaLogistics.Pages.Companies
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<Company> CompanyList { get; set; }
        public async Task<IActionResult> OnGet()
        {
            CompanyList = await _db.Company.ToListAsync();
            return Page();
        }
    }
}
