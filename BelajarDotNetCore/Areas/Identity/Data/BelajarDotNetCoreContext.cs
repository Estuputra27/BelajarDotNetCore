using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelajarDotNetCore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BelajarDotNetCore.Data
{
    public class BelajarDotNetCoreContext : IdentityDbContext<IdentityUser>
    {
        

        public BelajarDotNetCoreContext(DbContextOptions<BelajarDotNetCoreContext> options)
            : base(options)
        {
        }

       
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().ToTable("Product");
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

       
    }

}
