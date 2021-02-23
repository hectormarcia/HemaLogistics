using HeMaLogistics.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeMaLogistics.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanySite> CompanySite { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<ActivityType> ActivityType { get; set; }
    }
}
