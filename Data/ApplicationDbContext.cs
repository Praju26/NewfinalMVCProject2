using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace NewfinalMVCProject2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {    
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NewfinalMVCProject2.Medicine> Medicine { get; set; }

        public DbSet<NewfinalMVCProject2.Medicine_Enterprise> Medical_Enterprise { get; set; }
    }
}
