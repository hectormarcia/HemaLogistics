using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeMaLogistics.Data;
using HeMaLogistics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HeMaLogistics.Pages.ServiceTypes
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<ServiceType> ServiceType { get; set; }

        public async Task<IActionResult> OnGet()
        {
            ServiceType = await _db.ServiceType.ToListAsync();
            return Page();
        }
    }
}
